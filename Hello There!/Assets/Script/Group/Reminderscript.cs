using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Reminderscript : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Prefabs;
    public GameObject Parent, AddContactsPanel, ContactListPage;
    private Dictionary<string, GameObject> cardControl;
    private GroupInformationcontrol controller;
    private Dictionary<string, string> individualList;
    private int i;
    private Transform Master;
    private string d = "1";

    // Start is called before the first frame update
    private void OnEnable()
    {
        Debug.Log("contactList rerender");
        i = 0;
        deleteAllCard();
        createNewCard();

        d = "1";//monday
        //d=day of week

    }

    void instantPrefab(Transform Master, int i, string name, string id)
    {
        GameObject placeholder = Instantiate(Prefabs, new Vector3(Master.position.x + 100, Master.position.y - 30 - i * 50, 0), Quaternion.identity);
        cardControl.Add(id, placeholder);
        placeholder.transform.SetParent(Master);
        IndividualCard temp = placeholder.GetComponent<IndividualCard>();
        temp.SetID(id);
        temp.SetPanel(AddContactsPanel, ContactListPage);
        changeCardText(id, name);
    }

    public void submitNewCard(string name, string id)
    {
        instantPrefab(Master, i, name, id);
        i++;
    }

    public void changeCardText(string id, string text)
    {
        TextMeshProUGUI TMP = cardControl[id].GetComponent<TextMeshProUGUI>();
        TMP.text = text;
    }
    public void deleteAllCard()
    {
        if (cardControl != null)
        {
            foreach (var x in cardControl.Keys)
            {
                Destroy(cardControl[x]);
            }
        }
    }

    public void createNewCard()
    {
        cardControl = new Dictionary<string, GameObject>();
        controller = Canvas.GetComponent<GroupInformationcontrol>();
        individualList = controller.GetIndividualMap();
        Master = Parent.GetComponent<Transform>();
        foreach (string x in individualList.Keys)
        {
            string[] str = individualList[x].Split(' ');
            if (str[6].Contains(d))
            {
                instantPrefab(Master, i, str[0].Substring(6, str[0].Length - 7).Replace("*", " "), x);
           
            }
             i++;
        }
    }

    public void RemoveCard(string id)
    {
        Debug.Log("delete click");
        Destroy(cardControl[id]);
        controller.DeleteIndividual(id);
    }
}
