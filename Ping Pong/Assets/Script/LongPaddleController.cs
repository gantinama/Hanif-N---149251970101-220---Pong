using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongPaddleController : MonoBehaviour
{
    public PowerUpManager manager;
    public PaddleController paddleLeft;
    public PaddleController paddleRight;
    public Collider2D ball;
    public float effect;


    private void Start() 
    {   
        
    }

    private void Update() {
        
    }

    private void OnTriggerEnter2D(Collider2D collition) 
    {

        if (collition == ball)
        {
            if (ball.GetComponent<Ball>().isRight == true)
            {
                paddleRight.GetComponent<PaddleController>().LongPaddle(effect);
            }
            if (ball.GetComponent<Ball>().isRight == false)
            {
                paddleLeft.GetComponent<PaddleController>().LongPaddle(effect);
                Debug.Log("bisa");
            }
            manager.RemovePowerUp(gameObject);
        }
    }
}
