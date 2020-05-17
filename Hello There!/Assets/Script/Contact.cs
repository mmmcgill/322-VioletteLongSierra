using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contact : MonoBehaviour
{
    public GameObject Canvas;
    private GroupInformationcontrol db;
    private Dictionary<string, string> individual;
    // Start is called before the first frame update
    void Start()
    {
        db = Canvas.GetComponent<GroupInformationcontrol>();
        getMap();
        writeToDb();
        foreach(var item in individual.Keys){
            Debug.Log(item + individual[item]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void getMap(){
        individual = db.GetIndividualMap();
    }
    private void writeToDb(){
        string Id = db.IdGenerator();
        db.SetIndividual(Id, "this is placebo");
    }
}
