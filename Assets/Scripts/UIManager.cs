using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject cultureList;
    public Toggle[] checkMarks;
    public GameObject[] checkUIs;
    public Text[] labelTexts;
    public GameObject[] flags;

    public void BackScene()
    {
        SceneManager.LoadScene(0);
    }
    
    public void ShowCultureList()
    {
        cultureList.SetActive(true);
        if(checkMarks[0].isOn==true)
        {
            labelTexts[0].text = "윤공단";
        }
    }

    public void HideCultureList()
    {
        cultureList.SetActive(false);
    }

    public void YesCulture1()
    {
        checkMarks[0].isOn = true;
        checkUIs[0].SetActive(false);
        flags[0].GetComponent<BoxCollider>().enabled = false;
    }

}
