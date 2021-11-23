using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubemovement : MonoBehaviour
{
    public GameObject ball;
    public int delay = 50;
    private List<float> xpositions;
    public float minX;
    public float maxX;
    // Start is called before the first frame update
    void Start()
    {
        xpositions = new List<float>();
        for (int i = 0; i < delay; i++)
        {
            xpositions.Add(transform.position.x);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(xpositions[0], transform.position.y, transform.position.z);
        xpositions.RemoveAt(0);
        xpositions.Add(Mathf.Clamp(ball.transform.position.x, minX, maxX));
    }
}
