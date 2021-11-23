using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class timermanager : MonoBehaviour
{
    public float maxtime = 300;
    private float timeleft = 0;
    private TextMeshProUGUI timertext;
    public UnityEvent onTimerEnd;
    private bool timerEnded = false;
    // Start is called before the first frame update
    void Start()
    {
        timeleft = maxtime;
        timertext = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!timerEnded) {
            if (timeleft > 0)
            {
                timeleft -= Time.deltaTime;
            }
            else
            {
                timerEnded = true;
                onTimerEnd.Invoke();
            }
            float minutes = Mathf.FloorToInt(timeleft / 60);
            float seconds = Mathf.FloorToInt(timeleft % 60);
            timertext.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }
}
