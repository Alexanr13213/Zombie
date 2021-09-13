using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemChecker : MonoBehaviour
{
    public AudioClip OkSound, BoomSound;
    public int Score;
    public GameObject ScoreObject;
    Text scoreText;

    void Start()
    {
        scoreText = ScoreObject.GetComponent<Text>();
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == "Good")
        {
            Score = Score + 10;
            scoreText.text = Score.ToString();
            AudioSource.PlayClipAtPoint(OkSound, other.transform.position);
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "Bad")
        {
            Score = Score - 10;
            scoreText.text = Score.ToString();
            AudioSource.PlayClipAtPoint(BoomSound, other.transform.position);
            Destroy(other.gameObject);
        }
    }

}
