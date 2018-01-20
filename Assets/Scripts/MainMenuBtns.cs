using UnityEngine;
using System.Collections;

	[RequireComponent (typeof (AudioSource))]
 public class MainMenuBtns : MonoBehaviour {

		public string levelToLoad;
	 public Texture2D normalTexture;
	 public Texture2D rollOverTexture;
	 public AudioClip beep;
	 public bool quitButton = false;
	 public bool instructionsButton = false;
	 public GUIText textHints;

		 // Update is called once per frame
	 void Update () {

		 }

	 void OnMouseEnter() {
		 GetComponent<GUITexture>().texture = rollOverTexture;
		 }

	 void OnMouseExit() {

			 GetComponent<GUITexture>().texture = normalTexture;
		 }

	 IEnumerator OnMouseUp() {
		 GetComponent<AudioSource>().PlayOneShot (beep);
		 yield return new WaitForSeconds(0.35f);
		 if (quitButton) {
			 Application.Quit ();
			 } else if (instructionsButton) {
			 textHints.SendMessage("ShowHint",
			                          "You awake on a mysterious island..." +
			                          "Find a way to signal for help or face certain doom!");
			 }
		else {
			 Application.LoadLevel (levelToLoad);
			 }
		 }
	 }