using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class blockcontroller : MonoBehaviour
{
    public GameObject coinPrefab;
    public bool isQuestionBlock;
    public TextMeshProUGUI coinText;
    
    private int coinCount = 0;

    private void OnMouseDown()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform == transform)
            {
                if (isQuestionBlock)
                {
                    Instantiate(coinPrefab, transform.position, Quaternion.identity);

                    coinCount++;
                    
                    coinText.text = $"Coins: {coinCount}";
                }
                else
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}
