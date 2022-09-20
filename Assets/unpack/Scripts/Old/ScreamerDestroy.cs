using UnityEngine;

public class ScreamerDestroy : MonoBehaviour {
	public GameObject monstr;

	void  OnTriggerEnter ( Collider other  ){
		if(other.tag == "Player")
        {
            monstr.SetActive(false);
            Destroy(monstr);
        }
		 
	}
}