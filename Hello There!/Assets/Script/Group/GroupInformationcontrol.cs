using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;  
using System.IO;

public class GroupInformationcontrol : MonoBehaviour
{
    private Dictionary<string, List<string>> group;
    private Dictionary<string, string> individual;
    //active determine which group is being open
    private string active = "create new";
    // Start is called before the first frame update
    //path to file contains Group information
    private string path = @"Assets/Script/Information text file/temp/Information.txt";
    private string path2 = @"Assets/Script/Information text file/temp2/Information.txt";

    //path to file contains Individual infomation
    private string pathIndividual = @"Assets/Script/Information text file/temp/Individual.txt";


    void Start()
    {
        if(!File.Exists(path2)){
            using (FileStream fs = File.Create(path2));
        }
        group = new Dictionary<string, List<string>>();
        individual = new Dictionary<string, string>();

        //read the file and put into the dictionary
        using(StreamReader file = new StreamReader(path)){
            string ln;
            while((ln = file.ReadLine()) != null){
                //tempStorage.Add(ln);
                string[] IdPlacebo = ln.Split(' ');
                List<string> IdContain = new List<string>();                
                for(int i = 1; i< IdPlacebo.Length; i++) IdContain.Add(IdPlacebo[i]);
                group.Add(IdPlacebo[0], IdContain);
            }
            file.Close();
        }
        Debug.Log("read finish");
    }

    private void OnApplicationQuit() {
        using(StreamWriter writer = new StreamWriter(path2, true)){ //need on appliction close
            foreach (string item in group.Keys)
            {
                string input = item +" ";
                foreach(string x in group[item]) input += x + " ";
                writer.WriteLine(input);
            }
            Debug.Log("write finish");
            writer.Close();
        }

        if(File.Exists(path)){
            File.Delete(path);
        }

        File.Move(path2, path);
    }
    public Dictionary<string, string> GetIndividualMap(){//return the whole map of individual
        return individual;
    }


    public string GetIndividual(string id){ // return individual information by id
        return individual[id];
    }

    public void SetIndividual(string id, string information){
        if(group.ContainsKey(id)) Debug.Log("has key");
        else {
            individual.Add(id, information);
        }
    }

    public void DeleteIndividual(string id){
        individual.Remove(id);
    }

    public void SetNewActive(){
        active = "create new";
    }
    public void SetActiveId(string group){
        active = group;
    }

    public string getActive(){
        Debug.Log("getActive");
        return active;
    }

    public string IdGenerator(){
        return System.Guid.NewGuid().ToString();
    }
}
