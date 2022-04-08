using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float spawnRate = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCouroutine(SpawnTarget());
    }
    
    IEnumerator SpawnTarget(){
        while(true)
        yield return new WaitForSeconds(spawnRate);
        int index = Random.Range(0,SpawnTarget.Count);
        Instantiate(targets[index]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
