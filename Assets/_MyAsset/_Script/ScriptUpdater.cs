using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net;

public class ScriptUpdater : MonoBehaviour {
	public Text updateprompt;
	public Text UpdateText;
	public Canvas UpdateCanvas;
	// Update is called once per frame
	IEnumerator Start () {
		WWW Update = new WWW("https://immersivemedia.ph/updateScriptTest.txt");
		yield return Update;
		string update = Update.text;
		if(update == "1.1"){
			UpdateCanvas.enabled = false;
		}
		else
		{
			UpdateCanvas.enabled = true;
			UpdateText.text = "You Need To Update to Version"+ Update.text;
		}
	}

	public void Link(){
		Application.OpenURL("https://immersivemedia.ph/");
	}
}
