using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Input.GetKey("up");
        Debug.Log("hallo");

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("hallo");

            //transform.Translate(new Vector2(0f, 1f));

            transform.Translate(new Vector3(0f, 1f));ghj

        }
    }
}
