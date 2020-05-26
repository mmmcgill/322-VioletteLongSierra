using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CalendarSaveButton : MonoBehaviour
{
    /*Ideas:
    generate new random ID and put stuff inside
    */
    // Start is called before the first frame update
    public GameObject Canvas;
    private GroupInformationcontrol controller;
    //public TextMeshProUGUI newContact, newGroupName;
    public Text selectedDate, title;
    //public Text reminderInfo;
    private Dictionary<string, string> individual;
    void Start()
    {
        controller = Canvas.GetComponent<GroupInformationcontrol>();
        individual = controller.GetIndividualMap();
        //individual = controller.GetIndividual(id);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable() {

    }

    public void submit(){
        string id = controller.IdGenerator();
        // controller.SetGroup(newGroupName.text, id);
        /*Dictionary<string, List<string>> temp = controller.GetGroupMap();
        foreach(string x in temp.Keys){
            Debug.Log(x);
        }*/

        Debug.Log(selectedDate.text);
        Debug.Log(title.text);

        string textLine= "You Have the following reminder:" + title.text + " " + selectedDate.text;
        controller.SetIndividual(id, textLine);
       
    }
  

  
   
}
