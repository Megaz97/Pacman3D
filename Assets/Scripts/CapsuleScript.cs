using UnityEngine;
using System.Collections;

public class CapsuleScript : MonoBehaviour {
    private VarScript vm;
    private Spawn pc;
    

    void Awake()
    {
      vm = GameObject.Find("VarManager").GetComponent<VarScript>();
    }

    void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("Player"))
        {
            vm.pacDown = true;
            Destroy(other.gameObject);
            vm.livesNo--;
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       
	
	}
}
