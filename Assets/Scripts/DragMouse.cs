using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragMouse : MonoBehaviour
{
    private float deltaX,deltaY;
    private Rigidbody rb;
    public GameObject pen;
    private void Start()
    {
        pen.SetActive(false);
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(Input.touchCount>0)
        {
            if(Input.GetMouseButton(0))
            {
                pen.SetActive(true);

            }
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            switch(touch.phase)
            {
                case TouchPhase.Began:
                    deltaX = touchPos.x - transform.position.x;
                    deltaY = touchPos.y - transform.position.y;
                    break;

                case TouchPhase.Moved:
                    rb.MovePosition(new Vector2(touchPos.x - deltaX, touchPos.y - deltaY));
                    break;

                case TouchPhase.Ended:
                    rb.velocity = Vector2.zero;
                    break;
            }
        }
    }
}
