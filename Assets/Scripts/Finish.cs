using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private ScoreManager scoreManager;
    private AudioSource finishSound;

    private bool levelComleted = false;

    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
         if(collision.gameObject.name == "Player" && !levelComleted)
        {
            finishSound.Play();
            levelComleted = true;
            Invoke("CompleteLevel", 2f);
      
        }   
    }

    private void CompleteLevel()
    {
        scoreManager.UpdatePermanentScore();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
