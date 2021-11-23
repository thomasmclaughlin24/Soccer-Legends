using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public int redScore = 0;
    public int blueScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Goal(bool redPlayer)
    {
        if (redPlayer)
        {
            redScore += 1;
        }
        else
        {
            blueScore += 1;
        }
    }
}
