using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animation : MonoBehaviour
{
	
	[SerializeField] GameObject renderPannel;
	Animator animatorTransition;
    Vector3 initRot,initPos;
	private GameObject plankInstPrefab, crunchInstPrefab, squatInstPrefab;
	private GameObject content;
	
    // Start is called before the first frame update
	void Start()
	{
		startAnimation();
		initRot = gameObject.transform.localEulerAngles;
		initPos = gameObject.transform.localPosition;
		plankInstPrefab = (GameObject)Resources.Load("PlankInstructionTextPrafab");
		crunchInstPrefab = (GameObject)Resources.Load("CrunchInstructionTextPrefab");
        squatInstPrefab = (GameObject)Resources.Load("SquatInstructionTextPrefab");
		content = GameObject.Find("PoseInstructionObject");
		//GameObject PlankInstructionText = Instantiate(plankInstPrefab, content.transform);
        //PlankInstructionText.name = "PlankInstructionText";
	}

	private void anim0(){
		animatorTransition = GetComponent<Animator>();
		renderPannel.SetActive(true);
		this.transform.position = new Vector3((float)initPos.x, (float)initPos.y, (float)initPos.z);
		animatorTransition.SetInteger( "iAnim", 0 );
		
	}
	private void anim1(){
		GameObject PlankInstructionText = Instantiate(plankInstPrefab, content.transform);
        PlankInstructionText.name = "PlankInstructionText";
        Destroy(GameObject.Find("SquatInstructionText"));
		Destroy(GameObject.Find("CrunchInstructionText"));

		animatorTransition = GetComponent<Animator>();
		renderPannel.SetActive(true);
		this.transform.position = new Vector3((float)initPos.x, (float)initPos.y, (float)initPos.z);
		animatorTransition.SetInteger( "iAnim", 1 );
		
	}
	private void anim2(){
		GameObject CrunchInstructionText = Instantiate(crunchInstPrefab, content.transform);
        CrunchInstructionText.name = "CrunchInstructionText";
        Destroy(GameObject.Find("PlankInstructionText"));
		Destroy(GameObject.Find("SquatInstructionText"));

		animatorTransition = GetComponent<Animator>();
		renderPannel.SetActive(true);
		this.transform.position = new Vector3((float)initPos.x, (float)initPos.y, (float)initPos.z);
		animatorTransition.SetInteger( "iAnim", 2 );
		
	}
	private void anim3(){
		GameObject SquatInstructionText = Instantiate(squatInstPrefab, content.transform);
        SquatInstructionText.name = "SquatInstructionText";
        Destroy(GameObject.Find("PlankInstructionText"));
		Destroy(GameObject.Find("CrunchInstructionText"));

		animatorTransition = GetComponent<Animator>();
		renderPannel.SetActive(true);
		this.transform.position = new Vector3((float)initPos.x, (float)(initPos.y-0.55), (float)initPos.z);
		animatorTransition.SetInteger( "iAnim", 3 );
		

	}
	
	private void resetPos(){
		float xele = initRot.x;
		float yele = initRot.y;
		float zele = initRot.z;
		this.transform.rotation = Quaternion.Euler(xele, yele, zele);
	}
	
	
	public void startAnimation(){
		animatorTransition = GetComponent<Animator>();
		if(animatorTransition){
			animatorTransition.Play("Idle");
	    }
	}

}
