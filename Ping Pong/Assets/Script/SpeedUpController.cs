using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public float magnitute;
    // public int timeInterval;

    private void OnTriggerEnter2D(Collider2D collition) 
    {
        if (collition == ball)
        {
            ball.GetComponent<Ball>().SpeedUpBall(magnitute);
            manager.RemovePowerUp(gameObject);
        }
    }
}
