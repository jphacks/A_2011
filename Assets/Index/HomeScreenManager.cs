using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeScreenManager : MonoBehaviour
{
    InputField targetEnergyInputField, consumedEnergyInputField;
    HomeScreenValueScript homeScript;
    // Start is called before the first frame update
    void Start()
    {
        targetEnergyInputField = GameObject.Find("TargetEnergyInputField").GetComponent<InputField>();
        consumedEnergyInputField = GameObject.Find("ConsumedEnergyInputField").GetComponent<InputField>();
        homeScript = GameObject.Find("HomeObject").GetComponent<HomeScreenValueScript>();
    }

    

    // Update is called once per frame
    void Update()
    {
        homeScript.targetEnergy = targetEnergyInputField.text;
        homeScript.consumedEnergy = consumedEnergyInputField.text;
    }
}
