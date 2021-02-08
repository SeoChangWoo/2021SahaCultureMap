using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectSchoolManager : MonoBehaviour
{
    public Text school;
    public GameObject firstCanvas;
    public Transform playerPos;
    public GameObject secondCanvas;
    public Transform schoolModel;

    public void EnterButton()
    {
        if(school.text == "감천초등학교")
        {
            PlayerPrefs.SetInt("Position", 0);
            firstCanvas.SetActive(false);
            secondCanvas.SetActive(true);
        }
        else if(school.text == "괴정초등학교")
        {
            PlayerPrefs.SetInt("Position", 1);
            firstCanvas.SetActive(false);
            secondCanvas.SetActive(true);
        }
        else if (school.text == "구평초등학교")
        {
            PlayerPrefs.SetInt("Position", 2);
            firstCanvas.SetActive(false);
            secondCanvas.SetActive(true);
        }
        else if (school.text == "낙동초등학교")
        {
            PlayerPrefs.SetInt("Position", 3);
            firstCanvas.SetActive(false);
            secondCanvas.SetActive(true);
        }
        else if (school.text == "다대초등학교")
        {
            PlayerPrefs.SetInt("Position", 4);
            firstCanvas.SetActive(false);
            secondCanvas.SetActive(true);
        }
        int posIndex = PlayerPrefs.GetInt("Position");
        switch (posIndex)
        {
            case 0:
                playerPos.position = new Vector3(1.804f, 0, 2.71f);
                schoolModel.position = new Vector3(1.804f, 0, 2.71f);
                break;
            case 1:
                playerPos.position = new Vector3(-0.853f, 0, 4.121f);
                schoolModel.position = new Vector3(-0.853f, 0, 4.121f);
                break;
            case 2:
                playerPos.position = new Vector3(0.507f, 0, 2.212f);
                schoolModel.position = new Vector3(0.507f, 0, 2.212f);
                break;
            case 3:
                playerPos.position = new Vector3(-2.26f, 0, 1.636f);
                schoolModel.position = new Vector3(-2.26f, 0, 1.636f);
                break;
            case 4:
                playerPos.position = new Vector3(1.85f, 0, -1.284f);
                break;
        }
    }
}
