
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;

public class menuChoice : MonoBehaviour
{
 
    public Material m_WhiteFade;

    public Color color = Color.white;

    private bool GoFade = false;
    private bool GoOutFade = false;

    private bool C1open = false;
    private bool C2open = false;
    private bool C3open = false;

    public GameObject Hand;                  //zet hand hierop  @dit

    public GameObject WhiteFade;

    public GameObject C1;                     //dir is een obj die je als button gebruikt @dit
    public GameObject C2;
    public GameObject C3;

    public GameObject ScreenC1;               // dit is een 3d boject met 2 buttons erop @dit
    public GameObject ScreenC2;
    public GameObject ScreenC3;

    private GameObject ScreenC1Close = null;   // dit is de rode button om het schrem te sluiten @dit
    private GameObject ScreenC2Close = null;
    private GameObject ScreenC3Close = null;

    private GameObject ScreenC1Play = null;    // ddit is de groeene button om naar het volgende scherm tegaan (wereld) @dit
    private GameObject ScreenC2Play = null;
    private GameObject ScreenC3Play = null;


    private float MenuInvest = 0.2f;
    private float Tabs = 0.1f;
    public float MenuHeight = 0.2f;


    void Update()
    {
        

        if (Vector3.Distance(Hand.transform.position, C1.transform.position) < MenuInvest && C1open == false)
        {
            // spawn menu op goeie locatie   &&& De player spawnt altijd op zelfde locatie als vorige scene
            Instantiate(ScreenC1);
            C1open = true;
            C2open = false;
            C3open = false;
            Destroy(ScreenC2);
            Destroy(ScreenC3);
            ScreenC1.transform.position = new Vector3(C1.transform.position.x, C1.transform.position.y + MenuHeight, C1.transform.position.z);
            ScreenC1Close = GameObject.FindWithTag("SC1CLOSE");
            ScreenC1Play = GameObject.FindWithTag("SC1PLAY");
            Debug.Log("M1");
        }
        if (Vector3.Distance(Hand.transform.position, ScreenC1Close.transform.position) < Tabs)
        {
            Destroy(GameObject.FindWithTag("SCREEN1"));
            C1open = false;
            Debug.Log("M12");
        }
        if (Vector3.Distance(Hand.transform.position, ScreenC1Play.transform.position) < Tabs)
        {
            StartCoroutine(Drup());
        }
        /*
        //////
        ///
        if (Vector3.Distance(Hand.transform.position, C2.transform.position) < MenuInvest && C2open == false)
        {
            Instantiate(ScreenC2);
            C2open = true;
            C1open = false;
            C3open = false;
            Destroy(ScreenC1);
            Destroy(ScreenC3);
            ScreenC2Close = GameObject.FindWithTag("SC2CLOSE");
            ScreenC2Play = GameObject.FindWithTag("SC2PLAY");
            Debug.Log("M2");
        }
        if (Vector3.Distance(Hand.transform.position, ScreenC2Close.transform.position) < Tabs)
        {
            Destroy(GameObject.FindWithTag("SCREEN2"));
            C2open = false;
            Debug.Log("M22");
        }
        if (Vector3.Distance(Hand.transform.position, ScreenC2Play.transform.position) < Tabs)
        {
            StartCoroutine(Drup());
        }

        /////
        ///
        if (Vector3.Distance(Hand.transform.position, C3.transform.position) < MenuInvest && C3open == false)
        {
            Instantiate(ScreenC3);
            C3open = true;
            C1open = false;
            C2open = false;
            Destroy(ScreenC1);
            Destroy(ScreenC2);
            ScreenC3Close = GameObject.FindWithTag("SC3CLOSE");
            ScreenC3Play = GameObject.FindWithTag("SC3PLAY");
            Debug.Log("M3");
        }
        if (Vector3.Distance(Hand.transform.position, ScreenC3Close.transform.position) < Tabs)
        {
            Destroy(GameObject.FindWithTag("SCREEN3"));
            C3open = false;
            Debug.Log("M32");
        }
        if (Vector3.Distance(Hand.transform.position, ScreenC3Play.transform.position) < Tabs)
        {
            StartCoroutine(Drup());
        }

        */
    //    if (GoFade == true)
    //    {
     //       m_WhiteFade.color += color(1,1,1,0.1f);
    //    }
    //   if (GoOutFade == true)
   //     {
    //        m_WhiteFade.color -= color(1, 1, 1, 0.1f);
    //    }


    }




    IEnumerator Drup()
    {
        Debug.Log("Court");
        yield return new WaitForSeconds(0.1f);
        GoFade = true;
        yield return new WaitForSeconds(1f);
        if (C1open == true)
        {
            SceneManager.LoadScene("samplescene");              //verander de naam naar welke scene je wilt @dit
        }
        /*
        if (C2open == true)
        {
            SceneManager.LoadScene("BeginScene2");
        }
        if (C3open == true)
        {
            SceneManager.LoadScene("BeginScene3");
        }
        */
        Debug.Log("Done");
        yield return new WaitForSeconds(1f);
        GoFade = false;
        GoOutFade = true;
    }

}
