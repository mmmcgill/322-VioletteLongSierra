using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class contactlist : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Prefabs;
    public GameObject Parent, AddContactsPanel, ContactListPage;
    private Dictionary<string, GameObject> cardControl;
    private GroupInformationcontrol controller;
    private Dictionary<string, string> individualList;
    private int i = 0;
    private Transform Master;

    // Start is called before the first frame update
    void Start()
    {   
        cardControl = new Dictionary<string, GameObject>();
        controller = Canvas.GetComponent<GroupInformationcontrol>();
        individualList = controller.GetIndividualMap();
        Master = Parent.GetComponent<Transform>();
        foreach (string x in individualList.Keys)
        {
            string[] str = individualList[x].Split(' ');
            instantPrefab(Master, i, str[0].Substring(6, str[0].Length - 7).Replace("*", " "), x);
            i++;
        }
    }

    // Update is called once per
    void Update()
    {

    }

    void instantPrefab(Transform Master, int i, string name, string id)
    {
        GameObject placeholder = Instantiate(Prefabs, new Vector3(Master.position.x + 100, Master.position.y - 30 - i * 50, 0), Quaternion.identity);
        placeholder.transform.SetParent(Master);
        IndividualCard temp = placeholder.GetComponent<IndividualCard>();
        temp.SetID(id);
        temp.SetPanel(AddContactsPanel, ContactListPage);
        cardControl.Add(id, placeholder);
        changeCardText(id, name);
    }

    public void submitNewCard(string name, string id)
    {
       instantPrefab(Master,i, name, id);
        i++;
    }

    public void changeCardText(string id, string text){
        TextMeshProUGUI TMP = cardControl[id].GetComponent<TextMeshProUGUI>();
        TMP.text = text;
    }
}
