using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SaveButton : MonoBehaviour
{
    /*Ideas:
    generate new random ID and put stuff inside
    */
    // Start is called before the first frame update
    public GameObject Canvas;
    private GroupInformationcontrol controller;
    public TextMeshProUGUI  newContact, newGroupName;
    void Start()
    {
        controller = Canvas.GetComponent<GroupInformationcontrol>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable() {

    }

    public void submit(){
        string id = controller.IdGenerator();
        controller.SetGroup(newGroupName.text, id);
        /*Dictionary<string, List<string>> temp = controller.GetGroupMap();
        foreach(string x in temp.Keys){
            Debug.Log(x);
        }*/
    }
}
