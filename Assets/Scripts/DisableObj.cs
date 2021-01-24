using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableObj : MonoBehaviour
{
    public float disableTime; // 비활성화될 시간
    private void OnEnable()
    {
        CancelInvoke();
        Invoke("Disable", disableTime);
    }
    private void Disable()
    {
        gameObject.SetActive(false);
    }
}
