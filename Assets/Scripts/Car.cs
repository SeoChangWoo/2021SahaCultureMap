using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public Camera cam;
    public bool isMove;
    public Vector3 destination;
    public Animator anim;
    public Vector3 offsetCam;
    private void Start()
    {
        Application.targetFrameRate = 300;
    }
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out hit))
            {
                SetDestination(hit.point);
            }
        }
        Move();
        cam.transform.position = transform.position + offsetCam;
    }

    void SetDestination(Vector3 dest)
    {
        destination = dest;
        isMove = true;
        anim.SetBool("isMove", true);
    }

    void Move()
    {
        if (isMove)
        {
            var dir = destination - transform.position;
            transform.forward = dir;
            transform.position += dir.normalized * Time.deltaTime * 1.3f;
        }
        if(Vector3.Distance(transform.position, destination)<=0.1f)
        {
            isMove = false;
            anim.SetBool("isMove", false);
        }
    }
}
