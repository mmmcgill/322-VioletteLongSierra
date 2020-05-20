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
        PlayerPrefs.DeleteAll();
        if (!File.Exists(path2))
        {
            using (FileStream fs = File.Create(path2)) ;
        }
        individual = new Dictionary<string, string>();
        char[] delimiter = { ' ' };
        //read the file and put into the dictionary
        using (StreamReader file = new StreamReader(path))
        {
            string ln;
            while ((ln = file.ReadLine()) != null)
            {
                //tempStorage.Add(ln);
                string[] IdPlacebo = ln.Split(delimiter, 2);
                individual.Add(IdPlacebo[0], IdPlacebo[1]);
            }
            file.Close();
        }
        Debug.Log("read finish");
    }
    private void OnApplicationQuit()
    {
        using (StreamWriter writer = new StreamWriter(path2, true))
        { //need on appliction close
            foreach (string item in individual.Keys)
            {
                string input = item + " " + individual[item];
                writer.WriteLine(input);
                Debug.Log(input);
            }
            Debug.Log("write finish");
            writer.Close();
        }
        if (File.Exists(path))
        {
            File.Delete(path);
        }
        File.Move(path2, path);
    }
    public Dictionary<string, string> GetIndividualMap()
    {//return the whole map of individual
        return individual;
    }
    public string GetIndividual(string id)
    { // return individual information by id
        return individual[id];
    }
    public void SetIndividual(string id, string information)
    {
        if (individual.ContainsKey(id)) individual[id] = information;
        else
        {
            individual.Add(id, information);
        }
    }
    public Dictionary<string, string>.KeyCollection Keys(){
        return individual.Keys;
    }

    public Dictionary<string, string>.ValueCollection Values(){
        return individual.Values;
    }

    public void DeleteIndividual(string id)
    {
        individual.Remove(id);
    }
    public string IdGenerator()
    {
        return System.Guid.NewGuid().ToString();
    }
}