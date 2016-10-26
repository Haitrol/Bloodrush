using UnityEngine;
using System.Collections;

public class ClickHandler : MonoBehaviour {

    public LayerMask heartLayer;

    Camera cam;
    Animator anim;

    void Start()
    {
        cam = Camera.main.GetComponent<Camera>();

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

        if (Physics.Raycast(ray, heartLayer))
        {
            ScoreManager.IncreaseOxygen();
        }
    }

    void DetectTap()
    {
        Ray ray = cam.ScreenPointToRay(Input.GetTouch(0).position);

        if (Physics.Raycast(ray, heartLayer))
        {
            ScoreManager.IncreaseOxygen();
        }
    }
}
