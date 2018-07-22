using UnityEngine;
using System.Collections;

public class Wrap : MonoBehaviour {
    private Vector3 wrap;
    private PacManControllerScript pc;
    public float addPos;
    private VarScript vm;
   

    void Awake()
    {
        vm = GameObject.Find("VarManager").GetComponent<VarScript>();
    }

   
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (vm.pacDown == false)
        {
          pc = GameObject.Find("PacMan(Clone)").GetComponent<PacManControllerScript>();
        }
	    wrap = pc.transform.position;
      
}

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player")) 
        {
            wrap.x = -wrap.x + addPos;

        }
        pc.transform.position = wrap;
    }
}
