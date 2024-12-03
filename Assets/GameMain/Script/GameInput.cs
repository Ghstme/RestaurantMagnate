using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour 
{
    public static GameInput Instance { get; private set; }





    private PlayerInpuctActions playerInpuctActions;



    private void Awake()
    {
        Instance = this;
        playerInpuctActions = new PlayerInpuctActions();
        playerInpuctActions.Enable();
    }

    public Vector2 GetMovementVector()
    {
        Vector2 inputVector = playerInpuctActions.Player.Move.ReadValue<Vector2>();

        return inputVector;
    }

}
