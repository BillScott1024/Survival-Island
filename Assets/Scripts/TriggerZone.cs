using UnityEngine; 
using System.Collections;

public class TriggerZone : MonoBehaviour {
	public AudioClip lockedSound;
	public Light doorLight;
	public GUIText textHints;

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "Player") { 
			if (Inventory.charge == 4) { 
				transform.Find("door").SendMessage("DoorCheck"); 
				if (GameObject.Find ("PowerGUI")) {
					 Destroy(GameObject.Find("PowerGUI"));
 						doorLight.color = Color.green;
}
			}
			else
			{
			transform.Find("door").GetComponent<AudioSource>().PlayOneShot(lockedSound); 
				col.gameObject.SendMessage("HUDon");

				textHints.SendMessage ("ShowHint", "This door seems locked.. maybe that " +
				                        "generator needs power...");
			} 
		} 
}
}
