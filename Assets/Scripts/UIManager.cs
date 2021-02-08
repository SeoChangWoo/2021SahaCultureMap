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
    public GameObject[] explains;
    public GameObject guidePanel;
    public GameObject[] resultPanel;

    public void CloseGuideButton()
    {
        guidePanel.SetActive(false);
    }

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
        if(checkMarks[1].isOn==true)
        {
            labelTexts[1].text = "다대진 동헌";
        }
        if (checkMarks[2].isOn == true)
        {
            labelTexts[2].text = "정운공 순의비";
        }
        if (checkMarks[3].isOn == true)
        {
            labelTexts[3].text = "몰운대";
        }
    }

    public void HideCultureList()
    {
        cultureList.SetActive(false);
    }

    public void YesCulture1()
    {
        Invoke("TrueImage", 0.9f);
        Car.isFlag = false;
        checkMarks[0].isOn = true;
        checkUIs[0].SetActive(false);
        flags[0].GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(ExplainPanelShow(0, 0));        
    }
    public void YesCulture2()
    {
        Invoke("TrueImage", 0.9f);
        Car.isFlag = false;
        checkMarks[1].isOn = true;
        checkUIs[1].SetActive(false);
        flags[1].GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(ExplainPanelShow(1, 0));
    }
    public void YesCulture3()
    {
        Invoke("TrueImage", 0.9f);
        Car.isFlag = false;
        checkMarks[2].isOn = true;
        checkUIs[2].SetActive(false);
        flags[2].GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(ExplainPanelShow(2, 0));
    }
    public void YesCulture4()
    {
        Invoke("TrueImage", 0.9f);
        Car.isFlag = false;
        checkMarks[3].isOn = true;
        checkUIs[3].SetActive(false);
        flags[3].GetComponent<BoxCollider>().enabled = false;
        explains[3].SetActive(true);
        StartCoroutine(ExplainPanelShow(3, 0));
    }

    public void YesCulture5()
    {
        Invoke("FalseImage", 0.9f);
        Car.isFlag = false;
        checkUIs[4].SetActive(false);
        StartCoroutine(ExplainPanelShow(4, 1));
    }
    public void YesCulture6()
    {
        Invoke("FalseImage", 0.9f);
        Car.isFlag = false;
        checkUIs[5].SetActive(false);
        StartCoroutine(ExplainPanelShow(5, 1));
    }
    public void YesCulture7()
    {
        Invoke("FalseImage", 0.9f);
        Car.isFlag = false;
        checkUIs[6].SetActive(false);
        StartCoroutine(ExplainPanelShow(6, 1));
    }
    public void YesCulture8()
    {
        Invoke("FalseImage", 0.9f);
        Car.isFlag = false;
        checkUIs[7].SetActive(false);
        StartCoroutine(ExplainPanelShow(7, 1));
    }
    public void YesCulture9()
    {
        Invoke("FalseImage", 0.9f);
        Car.isFlag = false;
        checkUIs[8].SetActive(false);
        StartCoroutine(ExplainPanelShow(8, 1));
    }
    public void YesCulture10()
    {
        Invoke("FalseImage", 0.9f);
        Car.isFlag = false;
        checkUIs[9].SetActive(false);
        StartCoroutine(ExplainPanelShow(9, 1));
    }
    public void YesCulture11()
    {
        Invoke("FalseImage", 0.9f);
        Car.isFlag = false;
        checkUIs[10].SetActive(false);
        StartCoroutine(ExplainPanelShow(10, 1));
    }
    public void YesCulture12()
    {
        Invoke("FalseImage", 0.9f);
        Car.isFlag = false;
        checkUIs[11].SetActive(false);
        StartCoroutine(ExplainPanelShow(11, 1));
    }
    public void YesCulture13()
    {
        Invoke("FalseImage", 0.9f);
        Car.isFlag = false;
        checkUIs[12].SetActive(false);
        StartCoroutine(ExplainPanelShow(12, 1));
    }



    public void NoCulture1()
    {
        Invoke("FalseImage", 0.9f);
        Car.isFlag = false;
        checkUIs[0].SetActive(false);
        StartCoroutine(ExplainPanelShow(0, 1));
    }
    public void NoCulture2()
    {
        Invoke("FalseImage", 0.9f);
        Car.isFlag = false;
        checkUIs[1].SetActive(false);
        StartCoroutine(ExplainPanelShow(1, 1));
    }
    public void NoCulture3()
    {
        Invoke("FalseImage", 0.9f);
        Car.isFlag = false;
        checkUIs[2].SetActive(false);
        StartCoroutine(ExplainPanelShow(2, 1));
    }
    public void NoCulture4()
    {
        Invoke("FalseImage", 0.9f);
        Car.isFlag = false;
        checkUIs[3].SetActive(false);
        StartCoroutine(ExplainPanelShow(3, 1));
    }
    public void NoCulture5()
    {
        Invoke("TrueImage", 0.9f);
        Car.isFlag = false;
        checkUIs[4].SetActive(false);
        flags[4].GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(ExplainPanelShow(4, 0));
    }
    public void NoCulture6()
    {
        Invoke("TrueImage", 0.9f);
        Car.isFlag = false;
        checkUIs[5].SetActive(false);
        flags[5].GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(ExplainPanelShow(5, 0));
    }
    public void NoCulture7()
    {
        Invoke("TrueImage", 0.9f);
        Car.isFlag = false;
        checkUIs[6].SetActive(false);
        flags[6].GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(ExplainPanelShow(6, 0));
    }
    public void NoCulture8()
    {
        Invoke("TrueImage", 0.9f);
        Car.isFlag = false;
        checkUIs[7].SetActive(false);
        flags[7].GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(ExplainPanelShow(7, 0));
    }
    public void NoCulture9()
    {
        Invoke("TrueImage", 0.9f);
        Car.isFlag = false;
        checkUIs[8].SetActive(false);
        flags[8].GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(ExplainPanelShow(8, 0));
    }
    public void NoCulture10()
    {
        Invoke("TrueImage", 0.9f);
        Car.isFlag = false;
        checkUIs[9].SetActive(false);
        flags[9].GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(ExplainPanelShow(9, 0));
    }
    public void NoCulture11()
    {
        Invoke("TrueImage", 0.9f);
        Car.isFlag = false;
        checkUIs[10].SetActive(false);
        flags[10].GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(ExplainPanelShow(10, 0));
    }
    public void NoCulture12()
    {
        Invoke("TrueImage", 0.9f);
        Car.isFlag = false;
        checkUIs[11].SetActive(false);
        flags[11].GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(ExplainPanelShow(11, 0));
    }
    public void NoCulture13()
    {
        Invoke("TrueImage", 0.9f);
        Car.isFlag = false;
        checkUIs[12].SetActive(false);
        flags[12].GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(ExplainPanelShow(12, 0));
    }


    public void HideExplain1()
    {
        explains[0].SetActive(false);
    }
    public void HideExplain2()
    {
        explains[1].SetActive(false);
    }
    public void HideExplain3()
    {
        explains[2].SetActive(false);
    }
    public void HideExplain4()
    {
        explains[3].SetActive(false);
    }
    public void HideExplain5()
    {
        explains[4].SetActive(false);
    }
    public void HideExplain6()
    {
        explains[5].SetActive(false);
    }
    public void HideExplain7()
    {
        explains[6].SetActive(false);
    }
    public void HideExplain8()
    {
        explains[7].SetActive(false);
    }
    public void HideExplain9()
    {
        explains[8].SetActive(false);
    }
    public void HideExplain10()
    {
        explains[9].SetActive(false);
    }
    public void HideExplain11()
    {
        explains[10].SetActive(false);
    }
    public void HideExplain12()
    {
        explains[11].SetActive(false);
    }
    public void HideExplain13()
    {
        explains[12].SetActive(false);
    }

    IEnumerator ExplainPanelShow(int i, int x)
    {
        yield return new WaitForSeconds(4f);
        resultPanel[x].SetActive(false);
        explains[i].SetActive(true);
    }

    public void TrueImage()
    {
        resultPanel[0].SetActive(true);
    }

    public void FalseImage()
    {
        resultPanel[1].SetActive(true);
    }
}
