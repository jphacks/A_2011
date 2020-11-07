using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorkOutModeManager : MonoBehaviour
{
    private GameObject content;
    private GameObject crunchObjectPrefab, squatObjectPrefab;
    public Dropdown dropdown;

    public void ModeSelect(){
        int Mode = dropdown.value;
        Debug.Log(Mode);
        if(Mode == 0){
            GameObject CrunchObject = Instantiate(crunchObjectPrefab, content.transform);
            CrunchObject.transform.localPosition = new Vector3((float)(-230), (float)(-112), (float)(-10));
            CrunchObject.name = "CrunchObject";
            Destroy(GameObject.Find("SquatObject"));
        }else if(Mode == 1){
            GameObject SquatObject = Instantiate(squatObjectPrefab, content.transform);
            SquatObject.transform.localPosition = new Vector3((float)(-230), (float)(-112), (float)(-10));
            SquatObject.name = "SquatObject";
            Destroy(GameObject.Find("CrunchObject"));
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
        crunchObjectPrefab = (GameObject)Resources.Load("CrunchObjectPrefab");
        squatObjectPrefab = (GameObject)Resources.Load("SquatObjectPrefab");
        content = GameObject.Find("FormTestObject");
        dropdown = GameObject.Find("WorkOutModeDropdown").GetComponent<Dropdown>();
        GameObject CrunchObject = Instantiate(crunchObjectPrefab, content.transform);
        Debug.Log(CrunchObject.transform.position.x);
        Debug.Log(CrunchObject.transform.position.y);
        Debug.Log(CrunchObject.transform.position.z);
        CrunchObject.transform.localPosition = new Vector3((float)(-230), (float)(-112), (float)(-10));
        CrunchObject.name = "CrunchObject";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
