using UnityEngine;

public class ScreamerActive : MonoBehaviour {
	public GameObject monstr;


	void  OnTriggerEnter ( Collider other  ){
		if(other.tag == "Player") monstr.SetActive(true); 

	}
}