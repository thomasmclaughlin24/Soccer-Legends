using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openoptions : MonoBehaviour
{
    public GameObject panel;
    public KeyCode escapekey = KeyCode.Escape;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(escapekey))
        {
            panel.SetActive(!panel.activeSelf);
        }
    }
}
