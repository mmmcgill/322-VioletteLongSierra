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
    private GameObject[] GroupPanel;
    private GroupContainer toggle;
    private string ID;
    // Start is called before the first frame update
    void Start()
    {
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
        PlayerPrefs.SetString("active", "create new");
        toggle.GroupDetailToggle();
    }

    public void takeExist(){

        PlayerPrefs.SetString("active", this.ID);
        toggle.GroupDetailToggle();
        //render existing info panel if addNew is false;
    }

    public void setText(string ID){//call at the start of program to render information
        information.SetText(PlayerPrefs.GetString(ID));
        this.ID = ID;
    }

    public void test(){
        Debug.Log("test succeed");
    }
}
