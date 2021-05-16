using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsStartManagement : MonoBehaviour
{
    private GameObject[] ButtonsNumber;
    private Dictionary<string, Button> BB;

    private void Start()
    {
        ButtonsNumber = GameObject.FindGameObjectsWithTag("Number");
        GameObject[] Lines = GameObject.FindGameObjectsWithTag("Lines");
        AddToDic(Lines, BB);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //PrintButtons(Buttons);
        }
    }
    
    void AddToDic(GameObject[] lines, Dictionary<string, Button> toAdd)
    {
        foreach (GameObject line in lines)
        {
            string lineName = line.name;
            Button[] collumns = line.GetComponentsInChildren<Button>();
            foreach(Button collumn in collumns)
            {
                string collumnName = collumn.name;
                string keyName = lineName + collumnName;
                toAdd.Add(keyName, collumn);
            }
        }
    }
    /*
    void PrintButtons(Dictionary<string, GameObject> Dic)
    {
        for(int i = 0; i < Dic.Count; i++)
        {
            Debug.Log(Dic.Keys.ToString());
        }
    }*/
}
