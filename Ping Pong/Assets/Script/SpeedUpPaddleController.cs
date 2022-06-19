using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpPaddleController : MonoBehaviour
{
    public PowerUpManager manager;
    public PaddleController paddleLeft;
    public PaddleController paddleRight;
    public Collider2D ball;
    public float magnitute;


    private void Start() 
    {   
        
    }

    private void Update() {
        
    }

    private void OnTriggerEnter2D(Collider2D collition) 
    {

        if (collition == ball)
        {
            if (paddleRight.GetComponent<PaddleController>().isRight == true)
            {
                paddleRight.GetComponent<PaddleController>().SpeedUpPaddle(magnitute);
            }
            if (paddleRight.GetComponent<PaddleController>().isRight == false)
            {
                paddleLeft.GetComponent<PaddleController>().SpeedUpPaddle(magnitute);
                Debug.Log("bisa");
            }
            manager.RemovePowerUp(gameObject);
        }
    }
}
