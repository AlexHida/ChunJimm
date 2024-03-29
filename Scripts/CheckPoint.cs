using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChechPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.CompareTag("Player")){
            collision.GetComponent<PlayerRespaw>().reachedCheckPoint(transform.position.x, transform.position.y);
            GetComponent<Animator>().enabled = true;
        }
    }
}
