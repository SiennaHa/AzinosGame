using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] GameObject pipePrefab;

    [SerializeField] float spawnCoolDown;
    float currentTime;


    void Update()
    {
        if(gameManager.gameStarted == false)
        {
            return;
        }

        currentTime -= Time.deltaTime;

        if(currentTime <= 0)
        {
            currentTime = spawnCoolDown;
            SpawnPipe();
        }
    }

    void SpawnPipe()
    {
        Instantiate(pipePrefab, transform);
    }

}
