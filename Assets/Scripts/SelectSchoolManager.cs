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
        else if (school.text == "다선초등학교")
        {
            PlayerPrefs.SetInt("Position", 5);
            firstCanvas.SetActive(false);
            secondCanvas.SetActive(true);
        }
        else if (school.text == "다송초등학교")
        {
            PlayerPrefs.SetInt("Position", 6);
            firstCanvas.SetActive(false);
            secondCanvas.SetActive(true);
        }
        else if (school.text == "당리초등학교")
        {
            PlayerPrefs.SetInt("Position", 7);
            firstCanvas.SetActive(false);
            secondCanvas.SetActive(true);
        }
        else if (school.text == "몰운대초등학교")
        {
            PlayerPrefs.SetInt("Position", 8);
            firstCanvas.SetActive(false);
            secondCanvas.SetActive(true);
        }
        else if (school.text == "보림초등학교")
        {
            PlayerPrefs.SetInt("Position", 9);
            firstCanvas.SetActive(false);
            secondCanvas.SetActive(true);
        }
        else if (school.text == "사남초등학교")
        {
            PlayerPrefs.SetInt("Position", 10);
            firstCanvas.SetActive(false);
            secondCanvas.SetActive(true);
        }
        else if (school.text == "사동초등학교")
        {
            PlayerPrefs.SetInt("Position", 11);
            firstCanvas.SetActive(false);
            secondCanvas.SetActive(true);
        }
        else if (school.text == "사하초등학교")
        {
            PlayerPrefs.SetInt("Position", 12);
            firstCanvas.SetActive(false);
            secondCanvas.SetActive(true);
        }
        else if (school.text == "서천초등학교")
        {
            PlayerPrefs.SetInt("Position", 13);
            firstCanvas.SetActive(false);
            secondCanvas.SetActive(true);
        }
        else if (school.text == "승학초등학교")
        {
            PlayerPrefs.SetInt("Position", 14);
            firstCanvas.SetActive(false);
            secondCanvas.SetActive(true);
        }
        else if (school.text == "신남초등학교")
        {
            PlayerPrefs.SetInt("Position", 15);
            firstCanvas.SetActive(false);
            secondCanvas.SetActive(true);
        }
        else if (school.text == "신촌초등학교")
        {
            PlayerPrefs.SetInt("Position", 16);
            firstCanvas.SetActive(false);
            secondCanvas.SetActive(true);
        }
        else if (school.text == "신평초등학교")
        {
            PlayerPrefs.SetInt("Position", 17);
            firstCanvas.SetActive(false);
            secondCanvas.SetActive(true);
        }
        else if (school.text == "옥천초등학교")
        {
            PlayerPrefs.SetInt("Position", 18);
            firstCanvas.SetActive(false);
            secondCanvas.SetActive(true);
        }
        else if (school.text == "을숙도초등학교")
        {
            PlayerPrefs.SetInt("Position", 19);
            firstCanvas.SetActive(false);
            secondCanvas.SetActive(true);
        }
        else if (school.text == "응봉초등학교")
        {
            PlayerPrefs.SetInt("Position", 20);
            firstCanvas.SetActive(false);
            secondCanvas.SetActive(true);
        }
        else if (school.text == "장림초등학교")
        {
            PlayerPrefs.SetInt("Position", 21);
            firstCanvas.SetActive(false);
            secondCanvas.SetActive(true);
        }
        else if (school.text == "중현초등학교")
        {
            PlayerPrefs.SetInt("Position", 22);
            firstCanvas.SetActive(false);
            secondCanvas.SetActive(true);
        }
        else if (school.text == "하단초등학교")
        {
            PlayerPrefs.SetInt("Position", 23);
            firstCanvas.SetActive(false);
            secondCanvas.SetActive(true);
        }
        else if (school.text == "효림초등학교")
        {
            PlayerPrefs.SetInt("Position", 24);
            firstCanvas.SetActive(false);
            secondCanvas.SetActive(true);
        }
        else if (school.text == "하남초등학교")
        {
            PlayerPrefs.SetInt("Position", 25);
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
                schoolModel.position = new Vector3(1.85f, 0, -1.284f);
                break;
            case 5:
                playerPos.position = new Vector3(2.261f, 0, -0.362f);
                schoolModel.position = new Vector3(2.261f, 0, -0.362f);
                break;
            case 6:
                playerPos.position = new Vector3(1.369f, 0, -0.614f);
                schoolModel.position = new Vector3(1.369f, 0, -0.614f);
                break;
            case 7:
                playerPos.position = new Vector3(-1.635f, 0, 1.321f);
                schoolModel.position = new Vector3(-1.635f, 0, 1.321f);
                break;
            case 8:
                playerPos.position = new Vector3(1.54f, 0, -3.246f);
                schoolModel.position = new Vector3(1.54f, 0, -3.246f);
                break;
            case 9:
                playerPos.position = new Vector3(0.587f, 0, -0.307f);
                schoolModel.position = new Vector3(0.587f, 0, -0.307f);
                break;
            case 10:
                playerPos.position = new Vector3(-0.89f, 0, 1.897f);
                schoolModel.position = new Vector3(-0.89f, 0, 1.897f);
                break;
            case 11:
                playerPos.position = new Vector3(-1.506f, 0, 2.411f);
                schoolModel.position = new Vector3(-1.506f, 0, 2.411f);
                break;
            case 12:
                playerPos.position = new Vector3(-1.036f, 0, 2.584f);
                schoolModel.position = new Vector3(-1.036f, 0, 2.584f);
                break;
            case 13:
                playerPos.position = new Vector3(0.751f, 0, 3.202f);
                schoolModel.position = new Vector3(0.751f, 0, 3.202f);
                break;
            case 14:
                playerPos.position = new Vector3(-0.282f, 0, 4.063f);
                schoolModel.position = new Vector3(-0.282f, 0, 4.063f);
                break;
            case 15:
                playerPos.position = new Vector3(-2.088f, 0, 0.144f);
                schoolModel.position = new Vector3(-2.088f, 0, 0.144f);
                break;
            case 16:
                playerPos.position = new Vector3(-0.205f, 0, 1.152f);
                schoolModel.position = new Vector3(-0.205f, 0, 1.152f);
                break;
            case 17:
                playerPos.position = new Vector3(-1.296f, 0, 0.669f);
                schoolModel.position = new Vector3(-1.296f, 0, 0.669f);
                break;
            case 18:
                playerPos.position = new Vector3(-0.038f, 0, 2.714f);
                schoolModel.position = new Vector3(-0.038f, 0, 2.714f);
                break;
            case 19:
                playerPos.position = new Vector3(-3.481f, 0, 1.569f);
                schoolModel.position = new Vector3(-3.481f, 0, 1.569f);
                break;
            case 20:
                playerPos.position = new Vector3(2.158f, 0, -3.035f);
                schoolModel.position = new Vector3(2.158f, 0, -3.035f);
                break;
            case 21:
                playerPos.position = new Vector3(0.013f, 0, 0.062f);
                schoolModel.position = new Vector3(0.013f, 0, 0.062f);
                break;
            case 22:
                playerPos.position = new Vector3(2.235f, 0, -3.368f);
                schoolModel.position = new Vector3(2.235f, 0, -3.368f);
                break;
            case 23:
                playerPos.position = new Vector3(-2.567f, 0, 0.905f);
                schoolModel.position = new Vector3(-2.567f, 0, 0.905f);
                break;
            case 24:
                playerPos.position = new Vector3(0.443f, 0, -0.484f);
                schoolModel.position = new Vector3(0.443f, 0, -0.484f);
                break;
            case 25:
                playerPos.position = new Vector3(-2.312f, 0, -0.058f);
                schoolModel.position = new Vector3(-2.312f, 0, -0.058f);
                break;
        }
    }
}
