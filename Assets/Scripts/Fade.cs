using UnityEngine;
using System.Collections;

public class Fade : MonoBehaviour {
	public GUITexture loadGUI;
	void Start () {
		 Rect currentRes = new Rect (-Screen.width * 0.5f,
		                               -Screen.height * 0.5f,
		                               Screen.width,
		                               Screen.height);
		 GetComponent<GUITexture>().pixelInset = currentRes;
		 }

		 // Update is called once per frame
	 void Update () {

		 }

	void LoadAnim() {
		Instantiate (loadGUI);
	}
}
