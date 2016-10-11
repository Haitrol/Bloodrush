using UnityEngine;
using System.Collections;

public class SwipeScript : MonoBehaviour {

    public float sMagnitude = 5.0f;
    public float sSpeed;
    public float goalGrid = 1.0f;

    bool canSwipe = true;
    float swipeCD = 0.05f;

    void Update ()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchDelta = Input.GetTouch(0).deltaPosition;
            //transform.Translate(-touchDelta.x, 0, 0);
        }

        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            Vector2 touchDelta = Input.GetTouch(0).deltaPosition;

            //if (touchDelta.y > sMagnitude && canSwipe)
            //{
            //    Debug.Log("FLICK UP!");
            //    StartCoroutine(MoveCamera(0,1));
            //    canSwipe = false;
            //};

            //if (touchDelta.y < -sMagnitude && canSwipe)
            //{
            //    Debug.Log("FLICK DOWN!");
            //    StartCoroutine(MoveCamera(116, 1));
            //    canSwipe = false;
            //};

            if (touchDelta.x > sMagnitude && canSwipe)
            {
                Debug.Log("FLICK RIGHT!");
                StartCoroutine(MoveCamera(0,0));
                canSwipe = false;
            };

            if (touchDelta.x < -sMagnitude && canSwipe)
            {
                Debug.Log("FLICK LEFT!");
                StartCoroutine(MoveCamera(65,0));
                canSwipe = false;
            };
        }                
    }

    IEnumerator MoveCamera(float a, int upDown)
    {
        switch(upDown)
        {
            case 0:
            while (Vector3.Distance(transform.position, new Vector3(a, transform.position.y, transform.position.z)) > 0.05)
            {
                transform.position = new Vector3(Mathf.Lerp(transform.position.x, a, sSpeed * Time.deltaTime), transform.position.y, transform.position.z);
                yield return null;
            }
            break;

            case 1:
            while (Vector3.Distance(transform.position, new Vector3(transform.position.x, a, transform.position.z)) > 0.05)
            {
                transform.position = new Vector3(transform.position.x, Mathf.Lerp(transform.position.y, a, sSpeed * Time.deltaTime), transform.position.z);
                yield return null;
            }
            break;
        }

        yield return new WaitForSeconds(swipeCD);
        canSwipe = true;
        Debug.Log("Finished");
    }

}