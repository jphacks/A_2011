using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeScreenValueScript : MonoBehaviour
{
    InputField targetEnergyInputField, consumedEnergyInputField;
    Text toTargetEnergyText;
    private GameObject content;
    private GameObject congratulationsTextPrefab;
    public string targetEnergy, consumedEnergy;
    // Start is called before the first frame update
    void Start()
    {
        targetEnergyInputField = GameObject.Find("TargetEnergyInputField").GetComponent<InputField>();
        consumedEnergyInputField = GameObject.Find("ConsumedEnergyInputField").GetComponent<InputField>();
        toTargetEnergyText = GameObject.Find("ToTargetEnergyText").GetComponent<Text>();
        content = GameObject.Find("HomeObject");
        congratulationsTextPrefab = (GameObject)Resources.Load("CongratulationsTextPrefab");
    }

    public void InputTargetButtonPressed(){
        try{
            targetEnergy = targetEnergyInputField.text;
            int targetEnergyValue = int.Parse(targetEnergy);
            toTargetEnergyText.text = targetEnergyValue.ToString();
            if(int.Parse(toTargetEnergyText.text)==0){
                GameObject CongratulationsText = Instantiate(congratulationsTextPrefab, content.transform);
                CongratulationsText.name = "CongratulationsText";
            }else{
                Destroy(GameObject.Find("CongratulationsText"));
            }
        }catch{
            Debug.Log("Error while input target");
        }
    }
    public void InputConsumedButtonPressed(){
        try{
            targetEnergy = toTargetEnergyText.text;
            consumedEnergy = consumedEnergyInputField.text;
            int consumedEnergyValue = int.Parse(consumedEnergy);
            int targetEnergyValue = int.Parse(targetEnergy) - consumedEnergyValue;
            toTargetEnergyText.text = targetEnergyValue.ToString();
            if(int.Parse(toTargetEnergyText.text)==0){
                GameObject CongratulationsText = Instantiate(congratulationsTextPrefab, content.transform);
                CongratulationsText.name = "CongratulationsText";
            }else{
                Destroy(GameObject.Find("CongratulationsText"));
            }
        }catch{
            Debug.Log("Error while input consumed");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
