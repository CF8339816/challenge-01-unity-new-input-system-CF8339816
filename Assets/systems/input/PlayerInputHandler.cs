using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
   /

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
    public Vector2 movement = new Vector2(1f, 1f);
    public float movespeed = 2f;

    [SerializeField] Vector2 moveInput;

    [Header("Change Dimensions")]
    public Rigidbody Capsule;
    public Vector3 scale = new Vector3(1f, 1f, 1f);
    public float basescale = 1f;



    

    public void OnKick(/*InputAction.CallbackContext context*/)
    {
        //if (context.started)
        //{
        // charging = true;
        Debug.Log("kick charge started");
        //}

        //if (context.canceled)
        //{
        Debug.Log("kick charge completed");
        //}
    }



    public void OnMove(/*InputAction.CallbackContext context*/)
    {
        {
            bool w = Input.GetKey(KeyCode.W);
            bool s = Input.GetKey(KeyCode.S);
            bool a = Input.GetKey(KeyCode.A);
            bool d = Input.GetKey(KeyCode.D);
            if (w)
            {
                Vector3 move = new Vector3(0, 0, 1) * movespeed * Time.deltaTime;
                Cube.MovePosition(move);
                Debug.Log("Moved using w key");

                Debug.Log("move pls");
            }
            if (s)
            {
                Vector3 move = new Vector3(0, 0, -1) * movespeed * Time.deltaTime;
                Cube.MovePosition(move);
                Debug.Log("Moved using s key");

                Debug.Log("move pls");
            }
            if (a)
            {
                Vector3 move = new Vector3(-1, 0, 0) * movespeed * Time.deltaTime;
                Cube.MovePosition(move);
                Debug.Log("Moved using w key");

                Debug.Log("move pls");
            }
            if (d)
            {
                Vector3 move = new Vector3(1, 0, 0) * movespeed * Time.deltaTime;
                Cube.MovePosition(move);
                Debug.Log("Moved using w key");

                Debug.Log("move pls");
            }


        }
    }


    public void OnScale(/*InputAction.CallbackContext context*/)
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //scale = 

            Debug.Log("'Eat Me...'  scale up");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("'Drink Me...' scale down");
        }
    }

}














