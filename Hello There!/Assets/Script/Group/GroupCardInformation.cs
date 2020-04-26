using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupCardInformation 
{
    private string name;
    private int date;
    //private List<IndividualCard> information;
    public GroupCardInformation(int date, string name){
        this.name = name;
        this.date = date;
        //this.information = new List<>();
    }

    public void SetContactDate(int date){
        this.date = date;
    }

    public void SetGroupName(string name){
        this.name = name;
    }

    public string GetGroupName(){
        return name;
    }
    public int GetContactDate(){
        return date;
    }
    /*Add information here when Max got individualList done
    public List<IndividualCard> getIndividualList(){

    }

    public void SetIndividualList(IndividualCard a){

    }
    */
}
