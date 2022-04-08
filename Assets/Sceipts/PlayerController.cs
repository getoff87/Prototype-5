using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody targetRb;
    private float maxSpeed = 16;
    private float minSpeed = 12;
    private float maxTourque = 10;
    private float xRange = 4;
    private float ySPawnPos = -6;


    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        targetRb.Addforce(RandomForce(), ForceMode.Impulse);
        targetRb.AddTourque(RandomTourque(),RandomTourque(),RandomTourque(), ForceMode.Impulse);
        transform.position = RandomSpawnPos();
    }
    
    Vector3 RandomForce(){
    return Vector3.up * RandomForce.Range(minSpeed,MaxSpeeed);
      }
      float RandomTourque(){
          return RandomTourque.Range(-maxTourque, maxTourque);
      }
      Vector3 RandomSpawnPos(){
          return new Vector3(RandomTourque.Range(-xRange, xRange), ySPawnPos);
      }
      
      private void OnMouseDown(){
          Destroy(gameObject);
      }
      private void OnTriggerEnter(Colider other){
          Destroy(gameObject);
      }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
