using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameStarted;
    int currentScore = 0;
    int currentHightScore = 0;
    [SerializeField] PlayerControls player;

    [SerializeField] Transform azinosFlip;
    public float rotationSpeed = 90f;

    public bool spin = false;

    [SerializeField] private TextMeshProUGUI scoreWrite;
    [SerializeField] private TextMeshProUGUI highScoreWrite;
    [SerializeField] private TextMeshProUGUI startButton;

    [SerializeField] private Rigidbody2D rb;

    private void Update()
    {
        if(spin)
        {
            azinosFlip.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }
    }

    public void StartGame()
    {
        gameStarted = true;
        currentScore = 0;
        scoreWrite.text = currentScore.ToString();
        spin = false;
        player.StartGame();
       
    }

    public void PointScored()
    {
        currentScore += 1;
        scoreWrite.text = currentScore.ToString();
    }

    public void GameOver()
    {
        gameStarted = false;
        spin = true;
        rb.gravityScale = 3f;
        StartCoroutine(Wait());
            if (currentScore > currentHightScore)
            {
                currentHightScore = currentScore;
                highScoreWrite.text = highScoreWrite.ToString();
        }

    }

    public void Home()
    {
        SceneManager.LoadScene("SampleScene");
    }
 
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3f);
        startButton.text = "Fly Again!";
    }

}
