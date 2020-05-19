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
    public TextMeshProUGUI discord, interest, mobile, bday ,name, notes;
    public GameObject ContactListPage;
    private contactlist contact;

    void Start()
    {
        contact = ContactListPage.GetComponent<contactlist>();
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
        // controller.SetGroup(newGroupName.text, id);
        /*Dictionary<string, List<string>> temp = controller.GetGroupMap();
        foreach(string x in temp.Keys){
            Debug.Log(x);
        }*/


        Debug.Log(discord.text);
        Debug.Log(interest.text);
        Debug.Log(mobile.text);

        string txtLine = discord.text + " " + interest.text + " " + mobile.text+" "+ bday.text + " " + name.text + " " + notes.text;
        Debug.Log(txtLine);

        controller.SetIndividual(id,txtLine);
        contact.submitNewCard(txtLine);

    }
}
