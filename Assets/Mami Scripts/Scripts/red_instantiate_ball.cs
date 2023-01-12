using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class red_instantiate_ball : MonoBehaviour
{
    float timeDuration = 10.0f;
    Vector3 player_blue_location = new Vector3(-8, 9, -10); // Player blue ball spawn location.
    public GameObject red_ping_pong_ball;

    IEnumerator Start(){
        while(true){
            GameObject redPingPongBallInstance = Instantiate(red_ping_pong_ball, player_blue_location, Quaternion.identity);
            // Destroying the ball after the specified time duration.
            Destroy(redPingPongBallInstance, timeDuration);
            // Wait for the specified time duration before instantiating the next ball.
            yield return new WaitForSeconds(timeDuration);
        }
    }    
}