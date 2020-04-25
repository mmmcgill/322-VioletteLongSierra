using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGroup : MonoBehaviour
{
    public GameObject Panel;
    // Start is called before the first frame update
    public void OpenGroupPanel()
    {
        Debug.Log("this work");
        if(Panel != null) Panel.SetActive(true);
    }

}
