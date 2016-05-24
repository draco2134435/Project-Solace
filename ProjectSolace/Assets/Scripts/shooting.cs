using UnityEngine;
using System.Collections;

public class shooting : MonoBehaviour {
    public float cooldown;
    public float fireDelay = .5f;
    public GameObject bullet;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        cooldown -= Time.deltaTime;

        if (Input.GetKey(KeyCode.Space) && cooldown <= 0)
        {
            cooldown = fireDelay;

            Instantiate(bullet, transform.position, transform.rotation);
        }
	}
}
