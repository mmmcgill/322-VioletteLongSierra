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
    // Start is called before the first frame update
    void Start()
    {
        // this is to render existing group
        Transform master = GroupPanel.GetComponent<Transform>();
        string[] ID_List = PlayerPrefs.GetString("ID_List").Split(' ');
        for(int i = 0; i< ID_List.Length; i++){
            GameObject placebo = Instantiate(groupPrefabs, new Vector3(master.position.x, master.position.y + 30 * i, 0), Quaternion.identity); // scaling 
            OpenGroupInfoOpener script = placebo.GetComponent<OpenGroupInfoOpener>(); 
            script.setText(ID_List[i]);
            placebo.transform.SetParent(GroupPanel.transform);
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
}
