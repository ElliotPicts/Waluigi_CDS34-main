using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Echelle : MonoBehaviour
{
    // private bool inTrigger;
    // private Rigidbody2D playerRb;

    // // Start is called before the first frame update
    // void Start()
    // {
    //     playerRb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     if (inTrigger)
    //     {
    //         if(Input.GetAxisRaw("Vertical")){
    //             Debug.Log("échelle");
    //             float velocityY = Input.GetAxisRaw("Vertical") * 3f;
    //             playerRb.velocity = new Vector2(playerRb.velocity.x, velocityY);
    //         }
    //     }
    // }

    // private void OnTriggerEnter2D(Collider2D other)
    // {
    //     if (other.CompareTag("Player"))
    //     {
    //         inTrigger = true;
    //     }
    // }

    // private void OnTriggerExit2D(Collider2D other)
    // {
    //     if (other.CompareTag("Player"))
    //     {
    //         inTrigger = false;
    //     }
    // }
}
