using UnityEngine;
using System.Collections;

public class CapsuleBlueScript : MonoBehaviour {
    public GameObject Alien;
    private VarScript vm;
    public AudioClip death;


    void Awake()
    {
        vm = GameObject.Find("VarManager").GetComponent<VarScript>();
    }
    
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            vm.scoreNo += 200;
            vm.alienGone = true;
            Destroy(Alien);
        }
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
