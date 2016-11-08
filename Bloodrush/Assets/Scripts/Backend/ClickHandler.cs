using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    private Animator anim;
    private BeatManager bm;

    private Camera cam;

    public LayerMask heartLayer;

    private void Start()
    {
        cam = Camera.main.GetComponent<Camera>();
        bm = GameObject.FindGameObjectWithTag("Managers").GetComponent<BeatManager>();

        if (!GameObject.FindWithTag("Heart"))
            Debug.Log("No Heart found! Did you forget to tag it?");
    }

    private void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
            DetectTap();
        else if (Input.GetMouseButtonDown(0))
            DetectClick();
    }

    private void DetectClick()
    {
        var ray = cam.ScreenPointToRay(Input.mousePosition);

        CastRay(ray, heartLayer);
    }

    private void DetectTap()
    {
        var ray = cam.ScreenPointToRay(Input.GetTouch(0).position);

        CastRay(ray, heartLayer);
    }

    private void CastRay(Ray ray, LayerMask layer)
    {
        if (Physics.Raycast(ray, layer))
            bm.Incr();
    }
}