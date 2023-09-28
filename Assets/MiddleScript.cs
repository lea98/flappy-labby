using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleScript : MonoBehaviour
{
    public LogicScript logic;
    public AudioSource src;

    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
        src = GameObject.FindGameObjectWithTag("sound_src").GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3) { logic.IncreaseScore();

            src.clip = clip;
            src.time = 0.6f;
            src.Play();
        }
        
    }
}
