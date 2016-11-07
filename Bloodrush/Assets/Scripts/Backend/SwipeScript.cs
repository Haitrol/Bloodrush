using System.Collections;
using UnityEngine;

public class SwipeScript : MonoBehaviour
{
    public float flickMagnitude = 5.0f;
    public float pageChangeSpeed = 30.0f;

    public GameObject homePoint;
    public GameObject scrollPointRight;
    public GameObject scrollPointLeft;

    public float swipeSpeed;

    public bool swipeLock { get; set; }

    private Vector2 touchDelta;
    private bool canSwipe = true;
    private readonly float swipeCD = 0.1f;
    private bool atHome = true;
    private bool atLeft;
    private bool atRight;

    //string debugString = "";
    private GUIStyle style;

    private void Start()
    {
        Input.simulateMouseWithTouches = false;
        //debugString = atHome + "" + atRight + canSwipe;
    }

    private void Update()
    {
        if (!swipeLock && (Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Moved))
        {
            touchDelta += Input.GetTouch(0).deltaPosition;
            var touchMoveDelta = Input.GetTouch(0).deltaPosition;
            transform.Translate(-touchMoveDelta.x*swipeSpeed, 0, 0);
        }
        transform.position =
            new Vector3(
                Mathf.Clamp(transform.position.x, scrollPointLeft.transform.position.x,
                    scrollPointRight.transform.position.x), transform.position.y, transform.position.z);

        if (!swipeLock && (Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Ended))
        {
            //Vector2 touchDelta = Input.GetTouch(0).deltaPosition;

            if ((touchDelta.x > flickMagnitude) && canSwipe)
            {
                if (atHome)
                {
                    atHome = false;
                    atLeft = true;
                    canSwipe = false;
                    //touchDelta = Vector2.zero;
                    StartCoroutine(MoveCamera(scrollPointLeft.transform.position.x, 0));
                }

                if (atRight)
                {
                    atHome = true;
                    atRight = false;
                    canSwipe = false;
                    //touchDelta = Vector2.zero;
                    StartCoroutine(MoveCamera(homePoint.transform.position.x, 0));
                }
            }
            ;

            if ((touchDelta.x < -flickMagnitude) && canSwipe)
            {
                if (atHome)
                {
                    atHome = false;
                    atRight = true;
                    canSwipe = false;
                    //touchDelta = Vector2.zero;
                    StartCoroutine(MoveCamera(scrollPointRight.transform.position.x, 0));
                }

                if (atLeft)
                {
                    atHome = true;
                    atLeft = false;
                    canSwipe = false;
                    //touchDelta = Vector2.zero;
                    StartCoroutine(MoveCamera(homePoint.transform.position.x, 0));
                }
            }
            ;

            touchDelta = Vector2.zero;
        }
    }

    private void OnGUI()
    {
        style = new GUIStyle();
        style.fontSize = Screen.width/10;
        style.normal.textColor = Color.white;
        //GUILayout.TextArea(debugString, style);
    }

    public IEnumerator MoveCamera(float a, int upDown)
    {
        switch (upDown)
        {
            case 0:
                while (
                    Vector3.Distance(transform.position, new Vector3(a, transform.position.y, transform.position.z)) >
                    0.05)
                {
                    transform.position = new Vector3(
                        Mathf.Lerp(transform.position.x, a, pageChangeSpeed*Time.deltaTime), transform.position.y,
                        transform.position.z);
                    yield return null;
                }
                break;

            case 1:
                while (
                    Vector3.Distance(transform.position, new Vector3(transform.position.x, a, transform.position.z)) >
                    0.05)
                {
                    transform.position = new Vector3(transform.position.x,
                        Mathf.Lerp(transform.position.y, a, pageChangeSpeed*Time.deltaTime), transform.position.z);
                    yield return null;
                }
                break;
        }

        yield return new WaitForSeconds(swipeCD);
        canSwipe = true;
        //Debug.Log("Finished");
    }

    public void ArrowR()
    {
        if (canSwipe)
        {
            canSwipe = false;
            StartCoroutine(MoveCamera(65, 0));
        }
    }

    public void ArrowL()
    {
        if (canSwipe)
        {
            canSwipe = false;
            StartCoroutine(MoveCamera(0, 0));
        }
    }
}