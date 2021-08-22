using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Transform movePoint;
    public float speed;

    void Start()
    {
        movePoint.parent = null;
    }

    void Update()
    {
        //Player position follows movepoint position
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, speed * Time.deltaTime);

        //MovePoint position change
        if(Vector3.Distance(transform.position, movePoint.position) <= 0.001f) //if player is on movepoint, new input is allowed
        {
            //Horizontal input
            if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
            {
                movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
            }

            //Vertical input
            if(Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
                movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
            }
        }
    }
}
