using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TabletMenu : MonoBehaviour
{

    public bool OPTIONON = true;

    public Material m_EMcreditsscreen;
    public Material m_EMexitscreen;
    public Material m_EMlevelscreen;
    public Material m_EMoptionsscreenOFF;
    public Material m_EMoptionsscreenON;
    public Material m_EMstartscreen;

    public GameObject Hand;
    public GameObject Tablet;
    public GameObject FloatingPointBehindHead;

    //tag on button
    private GameObject ButtonExitGame;
    private GameObject ButtonBack;
    private GameObject ButtonCreditScreenOPTIONSCEENOFF;
    private GameObject ButtonCreditScreenOPTIONON;
    private GameObject ButtonLevelScreen;
    private GameObject StartLevel;
    private GameObject ExitScreen;
    private GameObject CreditScreen;
    private GameObject OptionScreenButton;


    //ButtonPads
    private GameObject ButtonScreenCredit;
    private GameObject ButtonScreenExit;
    private GameObject ButtonScreenLevels;
    private GameObject ButtonScreenOFFOption;
    private GameObject ButtonScreenONOption;
    private GameObject ButtonScreenStartScreen;


    public float HTM = 0.2f;
    void Update()
    {

        ButtonExitGame = GameObject.FindGameObjectWithTag("ButtonExitGame");
        ButtonBack = GameObject.FindGameObjectWithTag("BACKBUTTON");
        ButtonCreditScreenOPTIONSCEENOFF = GameObject.FindGameObjectWithTag("ButtonCreditScreenOPTIONSCEENOFF");
        ButtonCreditScreenOPTIONON = GameObject.FindGameObjectWithTag("ButtonCreditScreenOPTIONON");
        ButtonLevelScreen = GameObject.FindGameObjectWithTag("ButtonLevelScreen");
        StartLevel = GameObject.FindGameObjectWithTag("StartLevel");
        ExitScreen = GameObject.FindGameObjectWithTag("ExitScreen");
        CreditScreen = GameObject.FindGameObjectWithTag("CreditScreenl");
        OptionScreenButton = GameObject.FindGameObjectWithTag("OptionScreenButton");

        //rotations and positions
        ButtonScreenCredit.transform.position = Tablet.transform.position;
        ButtonScreenCredit.transform.rotation = Tablet.transform.rotation;

        ButtonScreenExit.transform.position = Tablet.transform.position;
        ButtonScreenExit.transform.rotation = Tablet.transform.rotation;

        ButtonScreenLevels.transform.position = Tablet.transform.position;
        ButtonScreenLevels.transform.rotation = Tablet.transform.rotation;

        ButtonScreenOFFOption.transform.position = Tablet.transform.position;
        ButtonScreenOFFOption.transform.rotation = Tablet.transform.rotation;

        ButtonScreenONOption.transform.position = Tablet.transform.position;
        ButtonScreenONOption.transform.rotation = Tablet.transform.rotation;

        ButtonScreenStartScreen.transform.position = Tablet.transform.position;
        ButtonScreenStartScreen.transform.rotation = Tablet.transform.rotation;

        Tablet.transform.position = FloatingPointBehindHead.transform.position;

        //de rest
        if (Vector3.Distance(Hand.transform.position, CreditScreen.transform.position) < HTM)
        {
            Tablet.GetComponent<Renderer>().material = m_EMcreditsscreen;
            Destroy(ButtonScreenStartScreen);
            Destroy(ButtonScreenCredit);
            Destroy(ButtonScreenExit);
            Destroy(ButtonScreenLevels);
            Destroy(ButtonScreenOFFOption);
            Destroy(ButtonScreenONOption);
            Instantiate(ButtonScreenCredit);
        }
        if (Vector3.Distance(Hand.transform.position, ButtonLevelScreen.transform.position) < HTM)
        {
            Tablet.GetComponent<Renderer>().material = m_EMlevelscreen;
            Destroy(ButtonScreenStartScreen);
            Destroy(ButtonScreenCredit);
            Destroy(ButtonScreenExit);
            Destroy(ButtonScreenLevels);
            Destroy(ButtonScreenOFFOption);
            Destroy(ButtonScreenONOption);
            Instantiate(ButtonScreenLevels);
        }
        if (Vector3.Distance(Hand.transform.position, OptionScreenButton.transform.position) < HTM)
        {
            Destroy(ButtonScreenStartScreen);
            Destroy(ButtonScreenCredit);
            Destroy(ButtonScreenExit);
            Destroy(ButtonScreenLevels);
            Destroy(ButtonScreenOFFOption);
            Destroy(ButtonScreenONOption);
            Instantiate(ButtonScreenONOption);
        }

        if(Tablet.GetComponent<Renderer>().material == m_EMoptionsscreenON)
        {
            if (OPTIONON == true)
            {
                Tablet.GetComponent<Renderer>().material = m_EMoptionsscreenON;
                AudioListener.volume = 0.5f;
            }
        }
        if (Tablet.GetComponent<Renderer>().material == m_EMoptionsscreenOFF)
        {
            if (OPTIONON == false)
            {
                Tablet.GetComponent<Renderer>().material = m_EMoptionsscreenOFF;
                AudioListener.volume = 0f;
            }
        }

        if (Vector3.Distance(Hand.transform.position, ButtonCreditScreenOPTIONON.transform.position) < HTM)
        {
            OPTIONON = true;
        }
        if (Vector3.Distance(Hand.transform.position, ButtonCreditScreenOPTIONSCEENOFF.transform.position) < HTM)
        {
            OPTIONON = false;
        }

        if (Vector3.Distance(Hand.transform.position, ButtonBack.transform.position) < HTM)
        {
            Tablet.GetComponent<Renderer>().material = m_EMstartscreen;
            Destroy(ButtonScreenStartScreen);
            Destroy(ButtonScreenCredit);
            Destroy(ButtonScreenExit);
            Destroy(ButtonScreenLevels);
            Destroy(ButtonScreenOFFOption);
            Destroy(ButtonScreenONOption);
            Instantiate(ButtonScreenStartScreen);
        }

        if (Vector3.Distance(Hand.transform.position, ExitScreen.transform.position) < HTM)
        {
            Tablet.GetComponent<Renderer>().material = m_EMexitscreen;
            Destroy(ButtonScreenStartScreen);
            Destroy(ButtonScreenCredit);
            Destroy(ButtonScreenExit);
            Destroy(ButtonScreenLevels);
            Destroy(ButtonScreenOFFOption);
            Destroy(ButtonScreenONOption);
            Instantiate(ButtonScreenExit);
        }

        if (Vector3.Distance(Hand.transform.position, ButtonExitGame.transform.position) < HTM)
        {
         //   Application.Quit();
        }

        if(Vector3.Distance(Hand.transform.position, StartLevel.transform.position) < HTM)
        {
            //SceneManager.LoadScene (sceneBuildIndex: Put-the-number-here );
            //SceneManager.LoadScene (sceneName:"Put-the-name-of-the-scene-here");
        }

    }

    


}
