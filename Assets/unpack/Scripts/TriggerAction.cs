using UnityEngine;

public class TriggerAction : MonoBehaviour {
	public GameObject triggerPanel;
    public GameObject monstr;

    void  OnTriggerEnter ( Collider col){
        if (col.tag == "Player") 
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            col.gameObject.GetComponent<AudioSource>().volume = 0;
            triggerPanel.SetActive(true);
            gameObject.SetActive(false);
            monstr.SetActive(false);
        } 

	}
}