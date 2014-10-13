using UnityEngine;
using System.Collections;

public class ToggleWeather : MonoBehaviour {



	bool rain = false;
	// Use this for initialization
	void Start () {

	
			
	
				
	}
	
	// Update is called once per frame
	void Update () {
	

		if (Input.GetKey (KeyCode.UpArrow) ){
			gameObject.SetActive (false);
			AudioListener.pause = true;
			rain = false;
				}

		if (Input.GetKey(KeyCode.DownArrow)) {
			gameObject.SetActive (true);
			AudioListener.pause = false;
			rain = true;
		}
						


			
			
				

	
	}
}
