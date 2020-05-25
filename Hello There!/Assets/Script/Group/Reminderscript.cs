using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reminderscript : MonoBehaviour
{
    public GameObject Canvas;

    private GroupInformationcontrol controller;
    // Start is called before the first frame update
    void Start()
    {

        controller = Canvas.GetComponent<GroupInformationcontrol>();
        foreach(var item in controller.Values())
        {
            string[] container = item.Split(' ');
            Debug.Log(container[0].Substring(6, container[0].Length - 7).Replace("*", " "));
            Debug.Log(container[6]);
            Debug.Log(item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
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

    public void changeCardText(string id, string text)
    {
        TextMeshProUGUI TMP = cardControl[id].GetComponent<TextMeshProUGUI>();
        TMP.text = text;
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
            instantPrefab(Master, i, str[0].Substring(6, str[0].Length - 7).Replace("*", " "), x);
            i++;
        }
    }
}
