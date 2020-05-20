using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddContactButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void createNew(){
        PlayerPrefs.SetString("id", "create new");
        Debug.Log(PlayerPrefs.GetString("id"));
    }
}
