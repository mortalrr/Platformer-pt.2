using UnityEngine;

public class Goal : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Mario"))
        {
            Debug.Log("Congratulations! You finished the level!");
        }
    }
}