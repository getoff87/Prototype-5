using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private float spawnRate = 1.0f;
    private int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public List<GameObject> target;
    public bool isGameActive;

    // Start is called before the first frame update
    void Start()
    {
        isGameActive = true;
        StartCouroutine(SpawnTarget());
        score = 0;
        UpdateScore(0);
        gameOverText.GameObject.Set.Active(true);
    }
    
    public void GameOver(){
        gameOverText.GameObject.Set.Active(true);
        isGameActive = false;
    }

    IEnumerator SpawnTarget(){
        while(isGameActive) {}
        yield return new WaitForSeconds(spawnRate);
        int index = Random.Range(0,SpawnTarget.Count);
        Instantiate(targets[index]);
        UpdateScore(5);
    }

    public void UpdateScore(int scoreToAdd){
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
