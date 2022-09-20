using UnityEngine;

public class ScreamerFalse : MonoBehaviour {
	public GameObject monstr;


	void  OnTriggerEnter ( Collider other  ){
		if(other.tag == "Player") monstr.SetActive(false); 

	}
}
