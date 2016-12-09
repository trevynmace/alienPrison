using UnityEngine;
using System.Collections;

public class characterScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var dudeman = GameObject.Find ("character");

		if(Input.GetKeyDown (KeyCode.LeftArrow))
		{
			Vector2 temp = new Vector2(dudeman.transform.position.x - 1f, dudeman.transform.position.y);
			dudeman.transform.position = temp;
		}
	}
}
