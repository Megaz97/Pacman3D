using UnityEngine;
using System.Collections;

public class PacManControllerScript : MonoBehaviour {
	public float maxSpeed = 10f;
	
    public float vertAT;
    public float horiAT;
    
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
    void Update () {
        
        
        GetComponent<Rigidbody>().velocity = new Vector3(horiAT * maxSpeed, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);
        GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, GetComponent<Rigidbody>().velocity.y, vertAT * maxSpeed);

        MovementControl();

       
  }

   void MovementControl()
   {
       float horiIn = Input.GetAxis("Horizontal");
       float vertIn = Input.GetAxis("Vertical");

       if (horiIn > 0)
       {
           horiAT = 1;
           vertAT = 0;
       }
       if (horiIn < 0)
       {
           horiAT = -1;
           vertAT = 0;
       }
       if (vertIn > 0)
       {
           horiAT = 0;
           vertAT = 1;
       }
       if (vertIn < 0)
       {
           horiAT = 0;
           vertAT = -1;
       }
       if (horiAT == 1 || vertAT == 1 || horiAT == -1 || vertAT == -1)
       {
           GetComponent<AudioSource>().mute = false;
           
       }
       else if (horiAT == 0 && vertAT == 0)
       {
           GetComponent<AudioSource>().mute = true;
       }
     
      
 }


	
    
    



   

}
