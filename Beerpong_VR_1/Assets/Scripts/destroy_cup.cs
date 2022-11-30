using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_cup : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        if(other.CompareTag("destroy_cup")){
            Destroy(other.gameObject);
        }
    }
}
