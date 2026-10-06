using UnityEngine;

public class camera : MonoBehaviour
{
   public Transform player;
    public Vector3 distancia;

    void Update()
    {
        transform.position = player.position+distancia;

    }
}