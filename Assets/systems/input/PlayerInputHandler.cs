using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{


    public Rigidbody sphereRB;
    public Vector3 direction = new Vector3(0, 1f, 0.5f);
    public float kickforce = 10f;


    public void OnKick(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            sphereRB.AddForce(direction * kickforce, ForceMode.Impulse);

            Debug.Log("Kick Started");
        }

        if (context.canceled)
        {
                      

            Debug.Log("Kick Canceled");
        }

        else
        {
            Debug.Log("Shit done f@c%3d up!");


        }
    }








}







