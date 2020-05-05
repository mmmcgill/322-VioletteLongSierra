using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void GoToTaksScene()
    {
        //int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        //  SceneManager.LoadScene(currentSceneIndex+1);
        SceneManager.LoadScene(1);
    }

    public void GoToCalendarScene()
    {
        //int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        //  SceneManager.LoadScene(currentSceneIndex+1);
        SceneManager.LoadScene(2);
    }

    public void GoToIndividualScene()
    {
        //int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        //  SceneManager.LoadScene(currentSceneIndex+1);
        SceneManager.LoadScene(0);
    }
}

    /*
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
*/