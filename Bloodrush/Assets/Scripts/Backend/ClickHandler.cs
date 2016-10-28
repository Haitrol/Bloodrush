using UnityEngine;
using System.Collections;

public class ClickHandler : MonoBehaviour {

    public LayerMask heartLayer;
    BeatManager bm;

    Camera cam;
    Animator anim;

    void Start()
    {
        cam = Camera.main.GetComponent<Camera>();
        bm = GameObject.FindGameObjectWithTag("Managers").GetComponent<BeatManager>();

        if (!GameObject.FindWithTag("Heart"))
            Debug.Log("No Heart found! Did you forget to tag it?");
    }

	void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            DetectTap();
        }
        else if(Input.GetMouseButtonDown(0))
        {
            DetectClick();
        }
    }

    void DetectClick()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        CastRay(ray, heartLayer);
    }

    void DetectTap()
    {
        Ray ray = cam.ScreenPointToRay(Input.GetTouch(0).position);

        CastRay(ray, heartLayer);
    }

    void CastRay(Ray ray, LayerMask layer)
    {
        if (Physics.Raycast(ray, layer))
        {
            bm.Incr();
        }
    }
}
