using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupContainer : MonoBehaviour
{
    /*Ideas:
    - GroupPrefabs: GroupUI like games, sport
    - GroupPanel: Parents component + setActive go here
    - GroupDetail: toggle groupDetail with existing information
    - Canvas: where information is stored.
    */

    public GameObject groupPrefabs, GroupPanel, GroupDetail, Canvas, Group;
    private List<GameObject> groupObject;
    private Dictionary<string, List<string>> group;
    private GroupInformationcontrol controller;
    private Transform master;
    private int index;
    // Start is called before the first frame update
    //TODO: check if need to delete component by keeping tabs
    private void Start()
    {
        // this is to render existing group
        controller = Canvas.GetComponent<GroupInformationcontrol>();
        group = controller.GetGroupMap();
        groupObject = new List<GameObject>();
        master = GroupPanel.GetComponent<Transform>();
        index = 0;
        Debug.Log(group);
        //Debug.Log(group);
        foreach(string x in group.Keys){
            Debug.Log(x);
            Instant(x);
            index++;
        }
    }

    /*private void OnEnable() {
        string action = PlayerPrefs.GetString("active");
        switch(action){
            case "nothing":
                break;
            default:
                IdList.Add(action);
                Instant(action, IdList.Count - 1, GroupPanel.GetComponent<Transform>());
                break;
        }
    }*/
    // Update is called once per frame
    void Update()
    {
        
    }

    public void GroupDetailToggle(){
        Group.SetActive(false);
        GroupDetail.SetActive(true);
    }

    public void Instant(string group){

        GameObject placebo = Instantiate(groupPrefabs, new Vector3(master.position.x + 120, master.position.y - 30 - 50 * index, 0), Quaternion.identity); // scaling 
        OpenGroupInfoOpener script = placebo.GetComponent<OpenGroupInfoOpener>(); 
        script.setText(group);
        script.SetController(controller);
        placebo.transform.SetParent(GroupPanel.transform);
        groupObject.Add(placebo);
    }


//testing method
    public void addObject(string group){
        Instant(group);
        index++;
    }
    public void removeObject(int index){
        Destroy(groupObject[index]);
    }
}

