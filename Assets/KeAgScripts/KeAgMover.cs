using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeAgMover : MonoBehaviour
{
    public float speed;
    public LayerMask isGround;
    public Transform wallHitBox;
    private bool wallHit;
    public float wallHitHeight;
    public float wallHitWidht;


    private void FixedUpdate()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        wallHit = Physics2D.OverlapBox(wallHitBox.position, new Vector2(wallHitWidht, wallHitHeight), 0, isGround);
        if (wallHit == true)
        {
            speed = speed * -1;
        }
    }
}
        
    
