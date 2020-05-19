using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class contactlist : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Prefabs;
    public GameObject Parent;
    private GroupInformationcontrol controller;
    private Dictionary<string, string> individualList;
    private int i = 0;
    private Transform Master;

    // Start is called before the first frame update
    void Start()
    {
        controller = Canvas.GetComponent<GroupInformationcontrol>();
        individualList = controller.GetIndividualMap();
        Master = Parent.GetComponent<Transform>();
        foreach (string x in individualList.Keys)
        {
            string[] str = individualList[x].Split(' ');
            instantPrefab(Master, i, str[0], x);
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
        TextMeshProUGUI TMP = placeholder.GetComponent<TextMeshProUGUI>();
        TMP.text = name;
        placeholder.transform.SetParent(Master);
        IndividualCard temp = placeholder.GetComponent<IndividualCard>();
        temp.SetID(id);
    }

    public void submitNewCard(string name)
    {
       instantPrefab(Master,i, name, controller.IdGenerator());
        i++;
    }
}
