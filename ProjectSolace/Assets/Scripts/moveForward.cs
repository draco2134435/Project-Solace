using UnityEngine;
using System.Collections;

public class moveForward : MonoBehaviour {
    private Vector3 pos;
    public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        pos = transform.position;
        Vector3 velocity = new Vector3(0, speed * Time.deltaTime, 0);
        pos += velocity;
        transform.position = pos;
	}
}
