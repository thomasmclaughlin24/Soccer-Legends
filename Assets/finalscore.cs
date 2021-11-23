using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class finalscore : MonoBehaviour
{
    private TextMeshProUGUI finalscoretext;
    // Start is called before the first frame update
    void Start()
    {
        finalscoretext = GetComponent<TextMeshProUGUI>();
        Debug.Log("Red Score: " + PlayerPrefs.GetInt("redscore").ToString());
        Debug.Log("Blue Score: " + PlayerPrefs.GetInt("bluescore").ToString());
    }

    // Update is called once per frame
    void Update()
    {
        finalscoretext.text = "Final Score: " + PlayerPrefs.GetInt("redscore").ToString() + " - " + PlayerPrefs.GetInt("bluescore").ToString();
    }
}
