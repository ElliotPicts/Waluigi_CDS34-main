using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlateformeMouvante : MonoBehaviour
{
    [SerializeField] private Vector3[] position;
    [SerializeField] private float speed;
    private int index;
    

    void Update(){
        Move();
    }

    private void Move(){
        transform.localPosition = Vector2.MoveTowards(transform.localPosition,position[index],speed*Time.deltaTime);
        if (transform.localPosition == position[index]){

            Vector3 CurrentScale = transform.localScale;
            CurrentScale.x = -CurrentScale.x;  
            transform.localScale = CurrentScale;
            
            if(index == position.Length-1){
                index=0;
            } else{       
                index++;
            }
        }
    }
}
