using UnityEngine;
using System.Collections;

public class characterScript : MonoBehaviour {
	GameObject dudeman;
	int direction = 0;

	// Use this for initialization
	void Start () {
		dudeman = GameObject.Find ("character");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey (KeyCode.LeftArrow))
		{
			direction = 1;
			Vector2 temp = new Vector2(dudeman.transform.position.x - 0.2f, dudeman.transform.position.y);
			dudeman.transform.position = temp;
		}
		else if(Input.GetKey (KeyCode.RightArrow))
		{
			direction = 2;
			Vector2 temp = new Vector2(dudeman.transform.position.x + 0.2f, dudeman.transform.position.y);
			dudeman.transform.position = temp;
		}
		else if(Input.GetKey (KeyCode.UpArrow))
		{
			direction = 3;
			Vector2 temp = new Vector2(dudeman.transform.position.x, dudeman.transform.position.y + 0.2f);
			dudeman.transform.position = temp;
		}
		else if(Input.GetKey (KeyCode.DownArrow))
		{
			direction = 4;
			Vector2 temp = new Vector2(dudeman.transform.position.x, dudeman.transform.position.y - 0.2f);
			dudeman.transform.position = temp;
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "background")
		{
			if (direction == 1) {	
				dudeman.transform.position = new Vector2 (dudeman.transform.position.x + 0.5f, dudeman.transform.position.y);
			}
		}
	}
}