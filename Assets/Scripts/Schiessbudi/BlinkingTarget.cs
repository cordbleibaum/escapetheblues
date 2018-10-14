using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkingTarget : MonoBehaviour {
	public float waitTime;
	public float speed;
	public float resetTime;

	public Transform up;
	public Transform down;
	public Transform right;
	public Transform left;

	private float timer;
	private float resetTimer;
	private bool move;
	private bool ready;
	private Vector3 movement;

	// Use this for initialization
	void Start () {
		timer = 0;
		move = false;
		float y = Random.Range(down.position.y, up.position.y);
		float z = Random.Range(left.position.z, right.position.z);
		transform.position = new Vector3(transform.position.x, y, z);
		resetTimer = 0;
		ready = true;
	}
	
	void Reset() {
		ready = false;
		transform.GetChild(0).gameObject.SetActive(false);
		GetComponent<Collider>().enabled = false;
	}

	// Update is called once per frame
	void Update () {
		if(ready) {
			foreach(Touch touch in Input.touches) {
				if(touch.phase == TouchPhase.Began) {
					RaycastHit hit;
					Ray ray = Camera.main.ScreenPointToRay(touch.position);
					if(Physics.Raycast(ray, out hit, 100.0f)) {
						if(hit.transform.gameObject.CompareTag("Target"))
							Reset();
					}
				}
			}

			if(Input.GetMouseButtonDown(0)) {
				RaycastHit hit;
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				if(Physics.Raycast(ray, out hit, 100.0f)) {
					if(hit.transform.gameObject.CompareTag("Target"))
						Reset();
				}
			}

			if(!move) {
				timer += Time.deltaTime;
				if(timer >= waitTime) {
					move = true;
					timer = 0;
				}
			} else {
				Vector2 direction = Random.insideUnitCircle;
				movement = new Vector3(0, speed*direction.x, speed*direction.y);
				transform.position = transform.position + movement*Time.deltaTime;
				if(transform.position.y > up.position.y)
					transform.position = new Vector3(transform.position.x, up.position.y, transform.position.z);
				if(transform.position.y < down.position.y)
					transform.position = new Vector3(transform.position.x, up.position.y, transform.position.z);
				if(transform.position.z > right.position.z)
					transform.position = new Vector3(transform.position.x, transform.position.y, right.position.z);
				if(transform.position.z < left.position.z)
					transform.position = new Vector3(transform.position.x, transform.position.y, left.position.z);
				move = false;
			}
		} else {
			resetTimer += Time.deltaTime;
			if(resetTimer >= resetTime) {
				//restart
				transform.GetChild(0).gameObject.SetActive(true);
				GetComponent<Collider>().enabled = true;
				resetTimer = 0;
				ready = true;
				float y = Random.Range(down.position.y, up.position.y);
				float z = Random.Range(left.position.z, right.position.z);
				transform.position = new Vector3(transform.position.x, y, z);
			}
		}
	}
}
