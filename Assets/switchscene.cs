using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchscene : MonoBehaviour
{
    // Start is called before the first frame update
    public void SceneSwitch(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
