using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int score;
    public Text textScore;
    public AudioSource src;
    public AudioClip clip;


    [ContextMenu("aaaa")]
    public void IncreaseScore()
    {
        score += 1;
        textScore.text = score.ToString();
    }

    public void PlayAgain()
    {
        src.clip = clip;
        src.time = 0.07f;
        src.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Awake()
    {
        DontDestroyOnLoad(src.transform);
    }

}
