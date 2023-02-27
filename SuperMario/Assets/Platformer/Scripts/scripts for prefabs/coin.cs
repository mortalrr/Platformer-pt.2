using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class coin : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Mario"))
        {
            CoinTracker.coin += 1;
        }
    }
}