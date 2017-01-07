using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Times : MonoBehaviour {
	public Text times;
	public float num  ;
	// Use this for initialization
	void Awake() {
		//num = 60;

	}
	void Start () {
		
		num = PlayerPrefs.GetFloat("amigo");
        
          
	}
	
	// Update is called once per frame
	void Update () {


		num -= Time.deltaTime;
		PlayerPrefs.SetFloat ("amigo", num);
		times.text = "Time: " + (int)num;
      
        if (num <= 0) {
           // Time.timeScale = 0f;
            Application.LoadLevel("Selecting");
            PlayerPrefs.SetInt("score",0);
        }
	}
}
