using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Controller : MonoBehaviour, IPointerDownHandler
{
    [Header("Camera")]
    public Camera cam;
    public GameObject touchEffect;
    RaycastHit hit;

    public void OnPointerDown(PointerEventData eventData)
    {
        Ray ray = cam.ScreenPointToRay(eventData.position);
        Physics.Raycast(ray, out hit);

        if(hit.transform !=null)
        {
            touchEffect.SetActive(false);
            touchEffect.transform.position = cam.WorldToScreenPoint(hit.point);
            touchEffect.SetActive(true);
        }
    }
}
