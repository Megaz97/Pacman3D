using UnityEngine;
using System.Collections;

public class Blocks : MonoBehaviour
{
    private GameObject[] block;
    public GameObject blockPrefab;
    public Vector3 secondpos;
	public int numBlocks = 11;
    public float xAppear;
    public float yAppear;
	public float xSpace;
	public float ySpace; 
	public float vert;
	public float hori;
	//public GameObject[] enemyrefab;
	//private GameObject[] Enemy;
	
	void Start() {
		secondpos = this.transform.position;
		block =  new GameObject [numBlocks];
		CreateBlocks (secondpos.x + hori, secondpos.z + vert);
	}

	void CreateBlocks (float Xpos, float Ypos)
	{
		for (int i = 0; i < numBlocks; i++) {
			secondpos = new Vector3 (Xpos + i * xSpace, 0,Ypos + i * ySpace);
			wall (i, secondpos);
		}
	}

	void wall (int startZ, Vector3 direction)
	{
		block [startZ] = Instantiate (blockPrefab, direction, Quaternion.identity) as GameObject;
	}

}