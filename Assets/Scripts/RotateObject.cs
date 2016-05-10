using UnityEngine;
using System.Collections;

public class RotateObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            Vector3 t = transform.localEulerAngles;
            t.x += 10 * Time.deltaTime;
            transform.eulerAngles = t;
        }
    }
}
