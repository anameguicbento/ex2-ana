using UnityEngine;

public class obstaculos : MonoBehaviour
{
    public Rigidbody player;
    void Update()
    {
        player.AddForce(0, 0, 10);
        if (Input.GetKeyDown(KeyCode.A))
        {
            player.AddForce(-10, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            player.AddForce(10, 0, 0);
        }
    }

}