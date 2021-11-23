using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goaldetector : MonoBehaviour
{
    public GameObject ball;
    private Vector3 startposition;
    public bool redGoal;
    public ScoreKeeper sk;
    public string scoreboardtext;
    public Canvas canvas;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == ball)
        {
            print("GOAL!!!");
            scoreboardtext = "GOAL!!!";
            scoreboardtext = "Red: " + scoreboardtext + "Blue: ";

            sk.Goal(!redGoal);
            ball.transform.position = startposition;
            ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
            ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
    }
    void Start()
    {
        startposition = new Vector3(ball.transform.position.x, ball.transform.position.y, ball.transform.position.z);
    }
}
