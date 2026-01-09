using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerInputHandler : MonoBehaviour
{

    [Header("Kick Settings")]
    public Rigidbody sphereRB;
    public Vector3 direction = new Vector3(0, 1f, 0.5f);
    public float kickforce = 0f;
    public float minkickforce = 2f;
    public float maxkickforce = 10f;
    public float kickforcecharging = .1f;
    bool chargingKick = false;


    [Header("Move Values")]
    public Rigidbody cubeRB;
    [SerializeField] Vector2 moveInput;
    public Vector2 movement = new Vector2(1f, 1f);
    public float movespeed = 2f;
    public Transform moverCube;

    [Header("Change Scale")]
    public Rigidbody capsuleRB;
    public Vector3 scale = new Vector3(1f, 1f, 1f);
    public float basescale = 1f;

    GameObject Capsuule;


    public void OnMove(InputAction.CallbackContext path)
    {
        //moveInput= path.ReadValue<Vector2>();

        //cubeRB.AddForce(moveInput * movespeed, ForceMode.Impulse);

        //Debug.Log("move input" + moveInput);   

        moveInput = path.ReadValue<Vector2>();

        Debug.Log(moveInput.x);
        Debug.Log(moveInput.y);


    }




    public void OnKick(InputAction.CallbackContext context)
    {
        if (context.started)
        {

            chargingKick = true;
           // sphereRB.AddForce(direction * kickforce, ForceMode.Impulse);
            Debug.Log("Kick started");

        }

        if (context.canceled)
        {
           
                sphereRB.AddForce(direction * kickforce, ForceMode.Impulse);
                Debug.Log("Kick Canceled");
           

           chargingKick = false;
           kickforce =  minkickforce;
            
        }

       
    }


    public void OnScale()
    {
        Vector3 currentScale = transform.localScale;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {


          // scale = Vector3(1 + basescale, 1 + basescale, 1 + basescale); 

            Debug.Log("'Eat Me...'  scale up");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
           

            //currentScale -= Vector3.one * basescale ;

            Debug.Log("'Drink Me...' scale down");
        }

      // scale = scale * basescale;
    }



    public void Update()
    {
     if(Keyboard.current.shiftKey.wasPressedThisFrame)
        {
            Debug.Log("I am a secret message for Sam TY for the additional Help !");
            // scale.Capsule 
        }

        if (chargingKick == true  && kickforce <= maxkickforce)
        {
            kickforce = kickforcecharging++;
        }
        else
        {
            kickforce = maxkickforce;
        }
      
        if (moveInput!=Vector2.zero)
            {
            moverCube.Translate(new Vector3(moveInput.x,0,moveInput.y) * Time.deltaTime * 5f);

        }


    }






}







