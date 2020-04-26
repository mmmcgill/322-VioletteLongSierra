using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupContainer : MonoBehaviour
{
    /*Ideas:
    - GroupPrefabs: GroupUI like games, sport
    - GroupPanel: Parents component + setActive go here
    - GroupDetail: toggle groupDetail with existing information
    */

    public GameObject groupPrefabs, GroupPanel, GroupDetail;
    private List<string> IdList;
    // Start is called before the first frame update
    //TODO: check if need to delete component by keeping tabs
    private void Start()
    {
        PlayerPrefs.DeleteAll();
        // this is to render existing group
        IdList = new List<string>();
        Transform master = GroupPanel.GetComponent<Transform>();
        string[] ID_List = PlayerPrefs.GetString("ID_List").Split(' ');
        for(int i = 0; i< ID_List.Length; i++){
            Instant(ID_List[i], i, master);
        }
    }

    private void OnEnable() {
        string action = PlayerPrefs.GetString("active");
        switch(action){
            case "nothing":
                break;
            default:
                IdList.Add(action);
                Instant(action, IdList.Count - 1, GroupPanel.GetComponent<Transform>());
                break;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void GroupDetailToggle(){
        GroupPanel.SetActive(false);
        GroupDetail.SetActive(true);
    }

    public void Instant(string Id, int position, Transform master){
        IdList.Add(Id);
        //temp fix position, will be doing overflow later
        GameObject placebo = Instantiate(groupPrefabs, new Vector3(master.position.x, (master.position.y + 90 ) - 30 * position, 0), Quaternion.identity); // scaling 
        OpenGroupInfoOpener script = placebo.GetComponent<OpenGroupInfoOpener>(); 
        script.setText(Id);
        placebo.transform.SetParent(GroupPanel.transform);
    }
}

