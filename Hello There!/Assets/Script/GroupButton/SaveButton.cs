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
        Debug.Log(name.text);
        Debug.Log(bday.text);
        Debug.Log(notes.text);

        string txtLine =  $"Name:\"{name.text}\" Bday:\"{bday.text}\" Mobile:\"{mobile.text}\" Discord:\"{discord.text}\" Interest:\"{interest.text}\" Notes:\"{notes.text}\"";
        Debug.Log(txtLine);

        controller.SetIndividual(id,txtLine);
        contact.submitNewCard(name.text);

    }
}
