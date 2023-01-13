using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blue_instantiate_Ball : MonoBehaviour
{
    float timeDuration = 10.0f;
    Vector3 player_red_location = new Vector3(-5, 9, -24); // Player red ball spawn location.
    public GameObject blue_ping_pong_ball;

    IEnumerator Start(){
        while(true){
            GameObject bluePingPongBallInstance = Instantiate(blue_ping_pong_ball, player_red_location, Quaternion.identity);
            // Destroying the ball after the specified time duration.
            Destroy(bluePingPongBallInstance, timeDuration);
            // Wait for the specified time duration before instantiating the next ball.
            yield return new WaitForSeconds(timeDuration);
        }
    }    
}