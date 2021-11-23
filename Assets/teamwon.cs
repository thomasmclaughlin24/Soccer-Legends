using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class teamwon : MonoBehaviour
{
    private TextMeshProUGUI winningteam;
    // Start is called before the first frame update
    void Start()
    {
        winningteam = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("redscore") > PlayerPrefs.GetInt("bluescore"))
            winningteam.text = "Red Team Wins!!!";
        else if (PlayerPrefs.GetInt("bluescore") > PlayerPrefs.GetInt("redscore"))
        {
            winningteam.text = "Blue Team Wins!!!";
        }
        else
        {
            winningteam.text = "Both Teams Tied!!!";
        }
    }
}
