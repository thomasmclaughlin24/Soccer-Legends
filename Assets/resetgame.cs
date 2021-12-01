using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetgame : MonoBehaviour
{
    public void ResetScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
