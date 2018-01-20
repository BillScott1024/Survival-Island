using UnityEngine;
using System.Collections;

public class TargetCollision : MonoBehaviour {
	private bool beenHit = false;
	private Animation targeRoot;
	public AudioClip hitSound;
	public AudioClip resetSound;
	public float resetTime = 3.0f;

	// Use this for initialization
	void Start () {
		targeRoot = transform.parent.transform.parent.GetComponent<Animation>();
	}
	void OnCollisionEnter(Collision col){
	
		if (beenHit == false && col.gameObject.name == "coconut") {

			StartCoroutine ("targetHit");   //并发运行，线程运行“targetHit”
		}
	}

	IEnumerator targetHit(){
	
		GetComponent<AudioSource>().PlayOneShot (hitSound);
		targeRoot.Play ("down");
		beenHit = true;
		CoconutWin.targets++;
		yield return new WaitForSeconds (resetTime);        //多线程，让出cpu时间 resettime (s)

		GetComponent<AudioSource>().PlayOneShot (resetSound);
		targeRoot.Play ("up");
		beenHit = false;
		CoconutWin.targets--;
	}
	// Update is called once per frame
	void Update () {
	
	}
}