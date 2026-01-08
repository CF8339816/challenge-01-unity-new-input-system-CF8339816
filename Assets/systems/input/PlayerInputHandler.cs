using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    
    
    [Header("Kick Settings")]
    public Rigidbody sphere;
    public Vector3 direction = new Vector3(0, 1f, 0.5f); 
    public float kickforce = 0f;
    public float minkickforce = 2f;
    public float maxkickforce = 10f;
    public float kickforcechargerate = 0.01f;
    bool charging = false; 


    [Header("Move Values")]
    public Rigidbody Cube;
    public Vector2 movement = new Vector2( 1f, 1f);
    public float movespeed = 2f;
   
    [SerializeField] Vector2 moveInput;



    public void OnKick(/*InputAction.CallbackContext context*/)
    {
        //if (context.started)
        //{
            charging = true;
            Debug.Log("kick charge started");
        //}

        //if (context.canceled)
        //{
        //    if (kickforce < minkickforce)
        //    {
        //        kickforce = minkickforce;
        //        Debug.Log("kick engaged");
        //    }

        //    if (kickforce > maxkickforce)
        //    {
        //        kickforce = maxkickforce;
        //        Debug.Log("kick charge completed");
        //    }

        //}
    }



    public void OnMove(/*InputAction.CallbackContext context*/)
    {
        //moveInput = context.ReadValue<Vector2>;
        //movement = 
        Debug.Log("move pls");

    }




}
