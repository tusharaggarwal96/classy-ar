using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

    public GameObject plane;

    public GameObject spawnpoint;
	
	void Start () {
	
	}
	
	
	void Update () {
	 if(transform.position.y < plane.transform.position.y -20)
        {
            transform.position = spawnpoint.transform.position;

        }
	}
}
