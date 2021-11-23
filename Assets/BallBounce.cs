using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public GameObject ball;
    public KeyCode kickKey = KeyCode.E;
    public float maxDistance;
    public float KickPowerUp;
    public float KickPowerForward;
    private Transform camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(kickKey) && Vector3.Distance(transform.position, ball.transform.position) < maxDistance)
        {
            print("Kick");
            Vector3 forceVector = (Vector3.up * KickPowerUp) + (camera.forward * KickPowerForward);
            ball.GetComponent<Rigidbody>().AddForce(forceVector);
        }
    }
}
