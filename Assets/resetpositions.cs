using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetpositions : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject ball;
    private Vector3 player1startpos;
    private Vector3 player2startpos;
    private Vector3 ballstartpos;
    // Start is called before the first frame update
    void Start()
    {
        player1startpos = player1.transform.position;
        player2startpos = player2.transform.position;
        ballstartpos = ball.transform.position;
    }

    // Update is called once per frame
    public void ResetPositions()
    {
        player1.transform.position = player1startpos;
        player2.transform.position = player2startpos;
        ball.transform.position = ballstartpos;
        ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
        ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
}
