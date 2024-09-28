//LogicScript
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{

    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource pointSound;


    [ContextMenu("Increase score")]
   public void AddScore(int scoreToAdd)
    {   
        playerScore = playerScore + scoreToAdd;
        scoreText.text=playerScore.ToString();
        AudioSource audioSource = GetComponent<AudioSource>();
        pointSound = audioSource;
        pointSound.Play();
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void GameOver()
    {
     AudioSource audioSource = GetComponent<AudioSource>();
     gameOverScreen.SetActive(true);
       
    }
    
    // Start is called before the first frame update
   /* void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}