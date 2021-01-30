using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    public GameObject[] checkMarks;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("확인");
    }
}
