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
        Car.isFlag = false;
        checkMarks[0].isOn = true;
        checkUIs[0].SetActive(false);
        flags[0].GetComponent<BoxCollider>().enabled = false;
        explains[0].SetActive(true);
    }
    public void YesCulture2()
    {
        Car.isFlag = false;
        checkMarks[1].isOn = true;
        checkUIs[1].SetActive(false);
        flags[1].GetComponent<BoxCollider>().enabled = false;
        explains[1].SetActive(true);
    }
    public void YesCulture3()
    {
        Car.isFlag = false;
        checkMarks[2].isOn = true;
        checkUIs[2].SetActive(false);
        flags[2].GetComponent<BoxCollider>().enabled = false;
        explains[2].SetActive(true);
    }
    public void YesCulture4()
    {
        Car.isFlag = false;
        checkMarks[3].isOn = true;
        checkUIs[3].SetActive(false);
        flags[3].GetComponent<BoxCollider>().enabled = false;
        explains[3].SetActive(true);
    }

    public void YesCulture5()
    {
        Car.isFlag = false;
        checkUIs[4].SetActive(false);
        explains[4].SetActive(true);
    }
    public void YesCulture6()
    {
        Car.isFlag = false;
        checkUIs[5].SetActive(false);
        explains[5].SetActive(true);
    }
    public void YesCulture7()
    {
        Car.isFlag = false;
        checkUIs[6].SetActive(false);
        explains[6].SetActive(true);
    }
    public void YesCulture8()
    {
        Car.isFlag = false;
        checkUIs[7].SetActive(false);
        explains[7].SetActive(true);
    }
    public void YesCulture9()
    {
        Car.isFlag = false;
        checkUIs[8].SetActive(false);
        explains[8].SetActive(true);
    }
    public void YesCulture10()
    {
        Car.isFlag = false;
        checkUIs[9].SetActive(false);
        explains[9].SetActive(true);
    }
    public void YesCulture11()
    {
        Car.isFlag = false;
        checkUIs[10].SetActive(false);
        explains[10].SetActive(true);
    }
    public void YesCulture12()
    {
        Car.isFlag = false;
        checkUIs[11].SetActive(false);
        explains[11].SetActive(true);
    }
    public void YesCulture13()
    {
        Car.isFlag = false;
        checkUIs[12].SetActive(false);
        explains[12].SetActive(true);
    }



    public void NoCulture1()
    {
        Car.isFlag = false;
        checkUIs[0].SetActive(false);
    }
    public void NoCulture2()
    {
        Car.isFlag = false;
        checkUIs[1].SetActive(false);
    }
    public void NoCulture3()
    {
        Car.isFlag = false;
        checkUIs[2].SetActive(false);
    }
    public void NoCulture4()
    {
        Car.isFlag = false;
        checkUIs[3].SetActive(false);
    }
    public void NoCulture5()
    {
        Car.isFlag = false;
        checkUIs[4].SetActive(false);
        flags[4].GetComponent<BoxCollider>().enabled = false;
        explains[4].SetActive(true);
    }
    public void NoCulture6()
    {
        Car.isFlag = false;
        checkUIs[5].SetActive(false);
        flags[5].GetComponent<BoxCollider>().enabled = false;
        explains[5].SetActive(true);
    }
    public void NoCulture7()
    {
        Car.isFlag = false;
        checkUIs[6].SetActive(false);
        flags[6].GetComponent<BoxCollider>().enabled = false;
        explains[6].SetActive(true);
    }
    public void NoCulture8()
    {
        Car.isFlag = false;
        checkUIs[7].SetActive(false);
        flags[7].GetComponent<BoxCollider>().enabled = false;
        explains[7].SetActive(true);
    }
    public void NoCulture9()
    {
        Car.isFlag = false;
        checkUIs[8].SetActive(false);
        flags[8].GetComponent<BoxCollider>().enabled = false;
        explains[8].SetActive(true);
    }
    public void NoCulture10()
    {
        Car.isFlag = false;
        checkUIs[9].SetActive(false);
        flags[9].GetComponent<BoxCollider>().enabled = false;
        explains[9].SetActive(true);
    }
    public void NoCulture11()
    {
        Car.isFlag = false;
        checkUIs[10].SetActive(false);
        flags[10].GetComponent<BoxCollider>().enabled = false;
        explains[10].SetActive(true);
    }
    public void NoCulture12()
    {
        Car.isFlag = false;
        checkUIs[11].SetActive(false);
        flags[11].GetComponent<BoxCollider>().enabled = false;
        explains[11].SetActive(true);
    }
    public void NoCulture13()
    {
        Car.isFlag = false;
        checkUIs[12].SetActive(false);
        flags[12].GetComponent<BoxCollider>().enabled = false;
        explains[12].SetActive(true);
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
}
