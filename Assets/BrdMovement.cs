using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BrdMovement : MonoBehaviour
{
	public Rigidbody2D rigidy;
    public GameObject go;
    private bool enabledd;
    public GameObject LogicManager;
    private LogicScript lc;
    public Text HighScore;
    public AudioSource src;
    public AudioClip clip_hs;


    private bool brdNoFly = false;

    // Start is called before the first frame update
    void Start()
    {
	gameObject.name = "Petar";
    go.SetActive(false);
        HighScore.enabled = false;
        lc = LogicManager.GetComponent<LogicScript>();
    }


    void OnBecameVisible()
    {
        enabledd = true;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) == true && !brdNoFly) { rigidy.velocity = Vector2.up * 9; }

        if (enabledd && !GetComponent<Renderer>().isVisible)
        {
            go.SetActive(true);
            brdNoFly = true;
            if (lc.score > PlayerPrefs.GetInt("highScore", lc.score))
            { PlayerPrefs.SetInt("highScore", lc.score);
                src.clip = clip_hs;
                src.Play();

            }

            HighScore.text = "High Score: " + PlayerPrefs.GetInt("highScore").ToString();
            HighScore.enabled = true;

        }
    }

        private void OnCollisionEnter2D(Collision2D collision)

    {
        if (collision.gameObject.layer == 6)
        {
            brdNoFly = true;
            
            go.SetActive(true);
            if (lc.score > PlayerPrefs.GetInt("highScore", lc.score))
                { PlayerPrefs.SetInt("highScore", lc.score);
                src.clip = clip_hs;
                src.Play();
            }
            HighScore.text = "High Score: " + PlayerPrefs.GetInt("highScore").ToString();

            HighScore.enabled = true;



        }

    }
}
