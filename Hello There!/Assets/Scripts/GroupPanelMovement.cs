using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupPanelMovement : MonoBehaviour
{
    public GameObject GroupPanel;
    public GameObject IndividualPanelOrig;
    public GameObject IndividualPanelActive;

    public bool MoveGroupPanel;
    public bool MoveGroupPanelBack;

    public float moveSpeed;
    public float tempPanelPos;

    // Start is called before the first frame update
    void Start()
    {
        GroupPanel.transform.position = IndividualPanelOrig.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(MoveGroupPanel == true)
        {
            GroupPanel.transform.position = Vector3.Lerp(GroupPanel.transform.position, IndividualPanelActive.transform.position, moveSpeed = Time.deltaTime);

            if(GroupPanel.transform.localPosition.x == tempPanelPos)
            {
                MoveGroupPanel = false;
                GroupPanel.transform.position = IndividualPanelActive.transform.position;
            }
        }
    }

    public void MovePanel()
    {
        MoveGroupPanelBack = false;
        MoveGroupPanel = true;
    }

    public void MovePanelBack()
    {
        MoveGroupPanel = false;
        MoveGroupPanelBack = true;
    }
}  
