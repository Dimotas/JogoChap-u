using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatController : MonoBehaviour
{
    public Camera cam;
    private Rigidbody2D rb;
    private float MaxWidth;
    private bool mexer;

    void Start()
    {
        if (cam == null) cam = Camera.main;
        rb = GetComponent<Rigidbody2D>();
        Vector3 UpperC = new Vector3(Screen.width, Screen.height, 0.0f);
        Vector3 dim = cam.ScreenToWorldPoint(UpperC);
        MaxWidth = dim.x-GetComponent<Renderer>().bounds.extents.x;
    }
    public void MudaMexer(bool modo)
    {
        mexer = modo;
        rb.MovePosition(new Vector2(0.0f,0.0f));
    }

    private void FixedUpdate()
    {
        Vector3 rawpos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 targetPos = new Vector2(Mathf.Clamp(rawpos.x,-MaxWidth,MaxWidth), 0.0f);
        if (mexer) rb.MovePosition(targetPos);
        
    }
}
