using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour
{
    public GameObject prefab;
    private GameObject obj;
    public bool respawn = true;
    private float respawnTimer;
    public float timer;
   
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (obj == null)
        {
            respawn = false;
        }
        if (respawn == false)
        {
            respawnTimer -= Time.deltaTime;
        }
        if (respawnTimer <= 0)
        {
            respawn = true;
            respawnTimer = timer;
        }
        if (obj == null && respawn == true)
        {
            obj = Instantiate(prefab, this.transform.position, Quaternion.identity) as GameObject;
        }
    }
}