using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoretext : MonoBehaviour
{
    public ScoreKeeper scorekeeper;
    private TextMeshProUGUI textScore;
    // Start is called before the first frame update
    void Start()
    {
        textScore = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(textScore!= null && scorekeeper != null  && scorekeeper.redScore!= null && scorekeeper.blueScore!= null)
            textScore.text = "Red: " + scorekeeper.redScore.ToString() + " Blue: " + scorekeeper.blueScore.ToString();
    }
}
