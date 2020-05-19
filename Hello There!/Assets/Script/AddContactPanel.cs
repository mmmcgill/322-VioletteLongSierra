using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddContactPanel : MonoBehaviour
{
    public GameObject Canvas;
    private GroupInformationcontrol controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = Canvas.GetComponent<GroupInformationcontrol>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable()
    {
        string id = PlayerPrefs.GetString("id");
        string information = controller.GetIndividual(id);
    }
}
