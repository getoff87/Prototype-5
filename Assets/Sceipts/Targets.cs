using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targets : MonoBehaviour
{
    // Start is called before the first frame update
   
   private Rigidbody targetRb;
   public ParticeSystem explosionParticle;
   private GameManager gameManager; 
   public int pointValue;
   private float minSpeed = 12;
   private float maxSpeed = 16;
   private float xRange = 4;
   private float ySPawnPos = -6;
   
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>(); 
        targetRb.Addforce(RandomForce(), ForceMode.Impulse);
        targetRb.AddTourque(RandomTourque(), RandomTourque(),RandomTourque(), ForceMode.Impulse);

        transorm.position = RandomSpawnPos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if(gameManager.isGameActive)
        {
            Destroy(gameObject);
            gameManager.UpdateScore(pointValue);
            Instantitate(explosionParticle, transform.position,
            explosionParticle.transform.rotation);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (!gameObject.CompareTag("Bad"))
        {
            gameManager.GameOver();
        }
    }
}
