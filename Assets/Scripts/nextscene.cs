using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class nextscene : MonoBehaviour
{
  
   public void Nextscene()
    {
        SceneManager.LoadScene("New Main Scene");
        Debug.Log("hi there");
    }
}
