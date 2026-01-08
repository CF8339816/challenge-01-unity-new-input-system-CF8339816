using UnityEngine;

public class PlayerInputScript : MonoBehaviour
{
    public Rigidbody sphere;

    public void OnKick()
    {
        Debug.Log("kick performed");
    }

    public void UpdateUI()
    {
        Debug.Log("UIpdate UI called");
    }




}
