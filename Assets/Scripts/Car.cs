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
    public static bool isFlag;

    private void Start()
    {
        Application.targetFrameRate = 300;
    }
    private void Update()
    {
        if (isFlag == false)
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
            isFlag = true;
            checkUIs[0].SetActive(true);
        }
        if(other.tag == "flag2")
        {
            isFlag = true;
            checkUIs[1].SetActive(true);
        }
        if (other.tag == "flag3")
        {
            isFlag = true;
            checkUIs[2].SetActive(true);
        }
        if (other.tag == "flag4")
        {
            isFlag = true;
            checkUIs[3].SetActive(true);
        }
        if (other.tag == "flag5")
        {
            isFlag = true;
            checkUIs[4].SetActive(true);
        }
        if (other.tag == "flag6")
        {
            isFlag = true;
            checkUIs[5].SetActive(true);
        }
        if (other.tag == "flag7")
        {
            isFlag = true;
            checkUIs[6].SetActive(true);
        }
        if (other.tag == "flag8")
        {
            isFlag = true;
            checkUIs[7].SetActive(true);
        }
        if (other.tag == "flag9")
        {
            isFlag = true;
            checkUIs[8].SetActive(true);
        }
        if (other.tag == "flag10")
        {
            isFlag = true;
            checkUIs[9].SetActive(true);
        }
        if (other.tag == "flag11")
        {
            isFlag = true;
            checkUIs[10].SetActive(true);
        }
        if (other.tag == "flag12")
        {
            isFlag = true;
            checkUIs[11].SetActive(true);
        }
        if (other.tag == "flag13")
        {
            isFlag = true;
            checkUIs[12].SetActive(true);
        }
    }
}
