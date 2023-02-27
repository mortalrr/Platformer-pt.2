using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinTracker : MonoBehaviour
{
    public static int coin=0;
    public TextMeshProUGUI coinText;

    void Update()
    {
        coinText.text = "x " + coin;
    }
}