using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    public GameObject curPanel;
    public GameObject GroupPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void returnGroupPanel(){
        this.curPanel.SetActive(true);
        this.GroupPanel.SetActive(false);
    }
}
