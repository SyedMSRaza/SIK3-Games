using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movements : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown("space"))
        {
            transform.Translate(Vector3.up * 50 * Time.deltaTime, Space.World);
        }
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Spinner_test2")
        {
            // make the object react when touching another player/beyblade
            transform.Translate(Vector3.back * 10 * Time.deltaTime, Space.World);
        }
    }
}
