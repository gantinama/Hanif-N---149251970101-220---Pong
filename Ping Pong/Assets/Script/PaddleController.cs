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
    private Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // get input 
        Vector3 movement = GetInput(); 
         
        // move object 
        MoveObject(movement); 
        
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
        transform.Translate(movement * Time.deltaTime);
        rig.velocity = movement;
    } 
}
