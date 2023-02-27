using UnityEngine;

public class goomba : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Mario"))
        {
            Debug.Log("You hit the Goomba! You died!");
        }
    }
}