using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{

    [SerializeField] PlayerInputHandler CharacterController;
    
    public InputAction moveAction;

    public InputAction jumpAction;


   
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");  
        
        jumpAction = InputSystem.actions.FindAction("Jump"); 
        

        Cursor.visible = false;
    }



}