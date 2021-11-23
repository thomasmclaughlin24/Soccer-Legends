using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public ScoreKeeper scoreKeeper;
    // Start is called before the first frame update
    public void TransitionScene(string sceneName)
    {
        PlayerPrefs.SetInt("redscore", scoreKeeper.redScore);
        PlayerPrefs.SetInt("bluescore", scoreKeeper.blueScore);
        SceneManager.LoadScene(sceneName);
    }
}
