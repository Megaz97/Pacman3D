using UnityEngine;
using System.Collections;

public class PacDot : MonoBehaviour {
    private VarScript vm;


    void Awake()
    {
        vm = GameObject.Find("VarManager").GetComponent<VarScript>();
    }


	void OnTriggerEnter(Collider other) {

        if (other.gameObject.CompareTag("Player"))
        {
            vm.scoreNo += 100;
            vm.dotCounter--;
            Destroy(this.gameObject);
        }		
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
