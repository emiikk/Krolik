using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    public CharacterController characterController;
    public float movemenetSpeed;
    
    void Update()
    {
        Vector3 direction = Vector3.zero;

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            direction = -Vector3.right * movemenetSpeed;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            direction = Vector3.right * movemenetSpeed;
        }
        // else if (Input.GetKey(KeyCode.W))
        // {
        //
        //     direction = Vector3.forward * movemenetSpeed;
        // }
        // else if (Input.GetKey(KeyCode.S))
        // {
        //
        //     direction = -Vector3.forward * movemenetSpeed;
        // }
        
        characterController.Move(direction);
    }
}
