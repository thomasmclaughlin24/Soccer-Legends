using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menucontrol : MonoBehaviour
{
    public GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(false);
        var vp = GetComponent<UnityEngine.Video.VideoPlayer>();
        vp.loopPointReached += EndReached;
    }

    // Update is called once per frame
    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        menu.SetActive(true);
    }
}
