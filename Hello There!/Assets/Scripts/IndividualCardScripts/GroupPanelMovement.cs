using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupPanelMovement : MonoBehaviour
{
    public GameObject GroupPanel;
    public GameObject IndividualPanelOrig;
    public GameObject IndividualPanelActive;

    public bool Move_Group_Panel;
    public bool Move_GroupPanel_Back;

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
        if(Move_Group_Panel)
        {
            GroupPanel.transform.position = Vector3.Lerp(GroupPanel.transform.position, IndividualPanelActive.transform.position, moveSpeed * Time.deltaTime);

            if(GroupPanel.transform.localPosition.x == tempPanelPos)
            {
                Move_Group_Panel = false;
                GroupPanel.transform.position = IndividualPanelActive.transform.position;
                tempPanelPos = -9999999.99f;
            }
            if (Move_Group_Panel)
            {
                tempPanelPos = GroupPanel.transform.position.x;
            }
        }
        if (Move_GroupPanel_Back)
        {
            GroupPanel.transform.position = Vector3.Lerp(GroupPanel.transform.position, IndividualPanelOrig.transform.position, moveSpeed * Time.deltaTime);

            if (GroupPanel.transform.localPosition.x == tempPanelPos)
            {
                Move_Group_Panel = false;
                GroupPanel.transform.position = IndividualPanelOrig.transform.position;
                tempPanelPos = -9999999.99f;
            }
            if (Move_GroupPanel_Back)
            {
                tempPanelPos = GroupPanel.transform.position.x;
            } 
        }
    }

    public void MovePanel()
    {
        Move_GroupPanel_Back = false;
        Move_Group_Panel = true;
    }

    public void MovePanelBack()
    {
        Move_Group_Panel = false;
        Move_GroupPanel_Back = true;
    }
}  
