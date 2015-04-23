using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class spherecontroll : MonoBehaviour {
	public Text caption;
	public int score;
	// Use this for initialization
	void Start () {
		score = 0;
	
	}
	
	// Update is called once per frame
	void Update () {


		transform.Translate (0.01f, 0.0f, 0.1f);
	}
	void OnMouseDown(){
		if (Input.GetMouseButtonDown (0)) {
			score = score +10;
			caption.text=score.ToString();
		}
	}
	void OnCollisionEnter(Collision collision)
	{

	}

}
