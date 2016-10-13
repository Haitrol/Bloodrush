using UnityEngine;
using System.Collections;

public class ClickHandler : MonoBehaviour {

    public int scoreAmount = 1;

    public LayerMask heartLayer;

    Camera cam;
    ScoreManager sm;
    Animator anim;

    void Start()
    {
        cam = Camera.main.GetComponent<Camera>();
        sm = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>();
        anim = GetComponent<Animator>();
    }

	void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray ray = cam.ScreenPointToRay(Input.GetTouch(0).position);

            if (Physics.Raycast(ray, heartLayer))
            {
                sm.IncreaseScore(scoreAmount);
                anim.SetTrigger("DokiDoki");
            }
        }
    }
}
