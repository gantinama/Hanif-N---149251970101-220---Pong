using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    //manggil kelas vector2
    //public Vector2 speed;

    public int speed;
    public KeyCode upKey; 
    public KeyCode downKey;
    public bool isRight;
    public bool hasLong = false;
    public bool hasSpeed = false;
    private float duration = 5;
    private Rigidbody2D rig;
    private float timer;
    private float effectMulti;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // get input 
        Vector2 movement = GetInput(); 
         
        // move object 
        MoveObject(movement); 

        if (hasLong == true)
        {
            timer += Time.deltaTime;
            if (timer > duration)
            {
                hasLong = false;
                timer = 0;
                LongPowerUpWearOff();
                Debug.Log(timer);
            }
        }
        if (hasSpeed == true)
        {
            timer += Time.deltaTime;
            if (timer > duration)
            {
                hasSpeed = false;
                timer = 0;
                SpeedPowerUpWearOff();
                Debug.Log(timer);
            }
        }
        // Debug.Log(gameObject);
    }

    //mengambil key dari keyboard
    private Vector2 GetInput() 
    { 
        if (Input.GetKey(upKey)) 
        { 
            return Vector2.up * speed; 
        } 
        else if (Input.GetKey(downKey))
        { 
            return Vector2.down * speed; 
        } 
         
        return Vector2.zero; 
    } 
    
    //ove object
    private void MoveObject(Vector2 movement) 
    { 
        // Debug.Log(transform.localScale.y);
        transform.Translate(movement * Time.deltaTime);
        rig.velocity = movement;
    } 

    public void LongPaddle(float effect)
    {
        Vector2 resize = transform.localScale;
        resize.y = resize.y * effect;
        transform.localScale = resize;
        hasLong = true;
        effectMulti = effect;    
            
        Debug.Log(resize + " " + effect + " " + isRight);

    }

    public void SpeedUpPaddle(float magnitute)
    {
        rig.velocity *= magnitute;
        hasSpeed = true;
        effectMulti = magnitute; 
        Debug.Log(magnitute);
        
    }

    public void LongPowerUpWearOff ()
    {
        Vector2 resize = transform.localScale;
        resize.y = resize.y / effectMulti;
        transform.localScale = resize;
        hasLong = false; 
    }

    public void SpeedPowerUpWearOff ()
    {
        rig.velocity /= effectMulti;
        hasSpeed = false; 
    }
}
