using UnityEngine;
using System.Collections;

public class ObjectMaker : MonoBehaviour {

	public GameObject ObjectToCreate;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < 1000; i++) {
			Object.Instantiate (ObjectToCreate, new Vector3 (i, i, i), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
