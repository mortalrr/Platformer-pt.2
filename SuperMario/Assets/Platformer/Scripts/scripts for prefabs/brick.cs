using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class brick : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Mario"))
        {
            Destroy(gameObject);

            ScoreTracker.score += 100;
        }
    }
}
