using UnityEngine;
using System.Collections;

public class IgnoreCollisions : MonoBehaviour {
   
    
    
    void Start()
    {
    Physics.IgnoreCollision(GameObject.FindGameObjectWithTag("Enemy").GetComponent<Collider>(), GetComponent<Collider>());
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
