using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{

    [Header("Kick Settings")]
    public Rigidbody sphereRB;
    public Vector3 direction = new Vector3(0, 1f, 0.5f);
    public float kickforce = 0f;
    public float minkickforce = 2f;
    public float maxkickforce = 10f;
    public float kickforcechargerate = 0.01f;
    bool charging = false;


    [Header("Move Values")]
    public Rigidbody cubeRB;
    [SerializeField] Vector2 moveInput;
    public Vector2 movement = new Vector2(1f, 1f);
    public float movespeed = 2f;


    [Header("Change Scale")]
    public Rigidbody capsuleRB;
    public Vector3 scale = new Vector3(1f, 1f, 1f);
    public float basescale = 1f;




    public void OnMove(InputAction.CallbackContext path)
    {
        moveInput= path.ReadValue<Vector2>();

        cubeRB.AddForce(moveInput * movespeed, ForceMode.Impulse);
      
        Debug.Log("move input" + moveInput);   

    }




    public void OnKick(InputAction.CallbackContext context)
    {
        if (context.started)
        {

            charging = true;
         

            Debug.Log("Kick Started");
        }

        if (context.canceled)
        {

            sphereRB.AddForce(direction * kickforce, ForceMode.Impulse);
            charging = false;
            kickforce =  minkickforce;
            Debug.Log("Kick Canceled");
        }

        else
        {
            Debug.Log("Shit done f@c%3d up!");


        }
    }


    public void OnScale()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
           basescale = basescale++ ;

            Debug.Log("'Eat Me...'  scale up");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            basescale = basescale--;
            Debug.Log("'Drink Me...' scale down");
        }

        scale = scale * basescale;
    }



    public void Update()
    {
                 
        if (charging == true && kickforce <= maxkickforce)
        {
            kickforce = kickforcechargerate;
        }


    }






}







