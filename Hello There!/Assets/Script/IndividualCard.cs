using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndividualCard : MonoBehaviour
{
    private string id;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void SetID(string id)
    {
        this.id = id;
    }

    public void Onclick()
    {
        PlayerPrefs.SetString("id", id);
    }
}
