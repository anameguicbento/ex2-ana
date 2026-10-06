using Unity.AppUI.Redux;
using UnityEngine;
using UnityEngine.InputSystem;

public class titi : MonoBehaviour
{
    public Rigidbody variavel;
    void Update()
    {
        variavel.AddForce (0, 0, 10);
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            variavel.AddForce(-10, 0, 0);
        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            variavel.AddForce(10, 0, 0);
        }
    }
}

