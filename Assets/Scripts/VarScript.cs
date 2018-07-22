using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VarScript : MonoBehaviour {
    public bool blue = false;
    private float blueTimer;
    public float timer;
    public bool starter,
                finished;
    public bool pacDown = false;
    private float pacDownTimer;
    public float pacTimer;
    public GameObject warp,
                      pacSpawn,
                      start,
                      gameOver;
    
    public Text score;
    public Text lives;
    public int scoreNo;
    public int livesNo;
    public int dotCounter = 198;
    public GameObject death,
                      alienDeath;
    public bool alienGone;
    private float alienTimer;
   
	// Use this for initialization
	void Start () {
        Time.timeScale = 0;
        blueTimer = timer;
        pacDownTimer = pacTimer;
        alienTimer = pacTimer;
        starter = true;
        finished = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonUp("Start") && Time.timeScale == 0)
        {
            Time.timeScale = 1;
            starter = false;
        }
        else if (Input.GetButtonUp("Start") && Time.timeScale == 1)
        {
            Time.timeScale = 0;
            starter = false;
        }
        if (blue == true)
        {
            blueTimer -= Time.deltaTime;
        }
        if (blueTimer <= 0)
        {
            blue = false;
            blueTimer = timer;
        }
        if (alienGone == true)
        {
            alienTimer -= Time.deltaTime;
        }
        if (alienTimer <= 0)
        {
            alienGone = false;
            alienTimer = pacTimer;
        }

        if (pacDown == true)
        {
         pacDownTimer -= Time.deltaTime;
         warp.SetActive(false);
        }
        if (pacDownTimer <= 0)
        {
            pacDown = false;
            pacDownTimer = pacTimer;
        }

        if (pacDown == false && livesNo > 0)
        {
            warp.SetActive(true);
        }

        if (livesNo == 0)
        {
            warp.SetActive(false);
            pacSpawn.SetActive(false);
            finished = true;
        }
        if (dotCounter == 0)
        {
            finished = true;
            Time.timeScale = 0;
        }
        if (finished == true && Input.GetButtonUp("Start"))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        if (starter == true && Input.GetButtonUp("Quit"))
        {
            Application.Quit();
        }
        
        
        TextEdit();
        death.SetActive(pacDown);
        alienDeath.SetActive(alienGone);
        start.SetActive(starter);
        gameOver.SetActive(finished);
	}

    void TextEdit()
    {
        score.text = "score " + (scoreNo);
        lives.text = "lives " + (livesNo);
    }
    /* GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("Dot") as GameObject[];
        Debug.Log(objectsWithTag.Length);*/
}
