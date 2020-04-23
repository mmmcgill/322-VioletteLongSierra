using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void GoToTasksScene()
    {
        SceneManager.LoadScene("Tasks");
    }

    public void GoToIndividualCardScene()
    {
        SceneManager.LoadScene("Individual_Card");
    }

    public void GoToCalendarScene()
    {
        SceneManager.LoadScene("Calendar");
    }

 //   public void GoToIndividualCardScene()
 //   {
 //       SceneManager.LoadScene("Individual_Card");
  //  }


  //  public void GoToIndividualCardScene()
   // {
     //   SceneManager.LoadScene("Individual_Card");
    //}
}
