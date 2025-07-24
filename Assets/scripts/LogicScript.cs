using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class LogicScript : MonoBehaviour
{

    public int playerScore;
    public int scoreIncreaseTreshold = 10; 
    public Text scoreText;
    public GameObject gameOverScreen;
    //public PipeSpawnScript pipeSpawnScript;

    [ContextMenu("Increase Score")]

    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }



//    void Start()
    
  //     pipeSpawnScript  = GameObject.FindGameObjectWithTag("Pipe2").GetComponent<PipeSpawnScript>();

    


  //  void Update()
    //{ 
      //  if 
        //    (playerScore > scoreIncreaseTreshold)
       
            
   // }
         



    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);

    }
}
