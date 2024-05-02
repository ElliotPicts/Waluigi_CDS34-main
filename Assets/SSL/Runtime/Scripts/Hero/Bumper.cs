using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    private Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Player")){
            if (collision.contacts[0].normal.y<0){
                // Vector2 currentVelocity = _rb.velocity;

                // currentVelocity.y = 7; // ou une autre valeur selon vos besoins

                // _rb.velocity = currentVelocity;
                // _rb.AddForce(Vector3.up * 7 * Time.deltaTime);

                _rb.AddForce(Vector2.up * 446545, ForceMode2D.Impulse);

                Debug.Log("contact par le haut");
            }
        }
    }
}
