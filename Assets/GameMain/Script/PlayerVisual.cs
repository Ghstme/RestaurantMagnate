using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class PlayerVisual : MonoBehaviour
{
    private Animator animator;
    private bool isRunning;

    private const string IS_RUNNING = "IsRunning";

    private void Awake()
    {
        animator = GetComponent<Animator>();
        if (animator == null)
        {
            Debug.LogError("Animator component not found on " + gameObject.name);
        }
    }

    private void Update()
    {
        if (MovePlayer.Instance != null)
        {
            bool currentRunningState = MovePlayer.Instance.IsRunning();
            if (currentRunningState != isRunning)
            {
                isRunning = currentRunningState;
                animator.SetBool(IS_RUNNING, isRunning);
            }
        }

    }
}
