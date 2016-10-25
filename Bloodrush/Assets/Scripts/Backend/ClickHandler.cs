using UnityEngine;
using System.Collections;

public class ClickHandler : MonoBehaviour {

    int scoreAmount = 1;

    public LayerMask heartLayer;

    Camera cam;
    ScoreManager sm;
    Animator anim;

    void Start()
    {
        cam = Camera.main.GetComponent<Camera>();
        sm = GameObject.FindGameObjectWithTag("Managers").GetComponent<ScoreManager>();
        //anim = GetComponent<Animator>();
    }

	void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray ray = cam.ScreenPointToRay(Input.GetTouch(0).position);

            if (Physics.Raycast(ray, heartLayer))
            {
                sm.IncreaseOxygen();
                //anim.SetTrigger("DokiDoki");
            }
        }else if(Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, heartLayer))
            {
                sm.IncreaseOxygen();
                //anim.SetTrigger("DokiDoki");
            }
        }
    }
}
