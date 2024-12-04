using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.CompilerServices;
public class MovePlayer : MonoBehaviour
{
    public static MovePlayer Instance { get; private set; }

    [SerializeField] private float movingSpeed = 2f;

    

    private float minMovingSpeed = 0.1f;
    private bool isRunning=false;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }


    private void FixedUpdate()
    {
        HadleMovement();
        

    }

    private void HadleMovement()
    {

        Vector2 inputVector = GameInput.Instance.GetMovementVector();
        inputVector = inputVector.normalized;
        rb.MovePosition(rb.position + inputVector * (movingSpeed * Time.fixedDeltaTime));

        if(Mathf.Abs(inputVector.x)>minMovingSpeed || Mathf.Abs(inputVector.y) > minMovingSpeed)
        {
            isRunning = true;
        }
        else
        {
            isRunning=false;
        }
         
    }
    public bool IsRunning()
    {
        return isRunning;
    }


}
