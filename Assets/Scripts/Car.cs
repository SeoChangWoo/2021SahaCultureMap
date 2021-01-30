using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Car : MonoBehaviour
{
    public Camera cam;
    public bool isMove;
    public Vector3 destination;
    public Animator anim;
    public Vector3 offsetCam;
    public GameObject[] checkUIs;

    private void Start()
    {
        Application.targetFrameRate = 300;
    }
    private void Update()
    {
        if (Input.GetMouseButton(1))
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "flag1")
        {
            checkUIs[0].SetActive(true);
        }
        else if(other.tag == "flag2")
        {
        }
        else if (other.tag == "flag3")
        {
        }
        else if (other.tag == "flag4")
        {
        }
    }
}
