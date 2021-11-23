using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class animateplayer : MonoBehaviour
{
    private Animator animator;
    public string forwardaxis;
    public string turnaxis;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.applyRootMotion = false;
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Forward", CrossPlatformInputManager.GetAxis(forwardaxis));
        animator.SetFloat("Turn", CrossPlatformInputManager.GetAxis(turnaxis));
    }
}
