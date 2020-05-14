using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OpenGroupInfoOpener : MonoBehaviour
{
    /*Variable explanation: ( might be outdate)
    - GroupPanel: toggling between GroupInfo and GroupPanel
    - ID: key of the file inside each group char 
    - Update, check if change file is to update or create new, might move this to Group edit component instead
    */
    public bool update; 
    public TextMeshProUGUI information; 
    public GameObject Canvas;
    private GameObject[] GroupPanel;
    private GroupContainer toggle;
    private GroupInformationcontrol controller;
    private string group;
    // Start is called before the first frame update
    void Start()
    {
        if(Canvas != null){
            controller = Canvas.GetComponent<GroupInformationcontrol>();
        }
        information = GetComponent<TextMeshProUGUI>();
        GroupPanel = GameObject.FindGameObjectsWithTag("GroupPanel");
        toggle = GroupPanel[0].GetComponent<GroupContainer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void createNew(){
        //render new info panel if addNew is true;
        controller.SetNewActive();
        toggle.GroupDetailToggle();
    }

    public void takeExist(){
        controller.SetActiveId(this.group);
        toggle.GroupDetailToggle();
        //render existing info panel if addNew is false;
    }

    public void setText(string group){//call at the start of program to render information
        information.SetText(group);
        this.group = group;
    }

    public void SetController(GroupInformationcontrol controller){
        this.controller = controller;
    }
    public void test(){
        Debug.Log("test succeed");
    }
}
