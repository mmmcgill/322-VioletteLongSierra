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

    public GameObject groupPrefabs, GroupPanel, GroupDetail, Canvas;
    private Dictionary<string, List<string>> group;
    private GroupInformationcontrol controller;
    // Start is called before the first frame update
    //TODO: check if need to delete component by keeping tabs
    private void Start()
    {
        PlayerPrefs.DeleteAll();
        // this is to render existing group
        controller = Canvas.GetComponent<GroupInformationcontrol>();
        group = controller.GetGroupMap();
        Transform master = GroupPanel.GetComponent<Transform>();
        int i = 0;
        //Debug.Log(group);
        foreach(string x in group.Keys){
            Instant(x, i, master);
            i++;
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
        GroupPanel.SetActive(false);
        GroupDetail.SetActive(true);
    }

    public void Instant(string Id, int position, Transform master){

        GameObject placebo = Instantiate(groupPrefabs, new Vector3(master.position.x + 40, (master.position.y + 90 ) - 50 * position, 0), Quaternion.identity); // scaling 
        OpenGroupInfoOpener script = placebo.GetComponent<OpenGroupInfoOpener>(); 
        script.setText(Id);
        script.SetController(controller);
        placebo.transform.SetParent(GroupPanel.transform);
    }
}

