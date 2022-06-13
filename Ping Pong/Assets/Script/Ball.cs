using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //manggil kelas vector2
    public Vector2 speed;
    public Vector2 resetPosition;

    //memanggil rigid body
    private Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("BALL: " + speed);
    }

    public void ResetBall()
    {
        transform.position = resetPosition;
    }

    public void SpeedUpBall(float magnitute)
    {
        rig.velocity *= magnitute;
    }
}
