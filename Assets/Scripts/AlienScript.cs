using UnityEngine;
using System.Collections;

public class AlienScript : MonoBehaviour {
    private VarScript vm;
    public GameObject capsuleOriginal,
                      capsuleBlue;

    void Awake()
    {
        vm = GameObject.Find("VarManager").GetComponent<VarScript>();
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        if (vm.blue == true)
        {
            capsuleOriginal.SetActive(false);
            capsuleBlue.SetActive(true);
        }
        if (vm.blue == false)
        {
            capsuleOriginal.SetActive(true);
            capsuleBlue.SetActive(false);
        }
	}
}
