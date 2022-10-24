using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public int currentNumberOfCoins;
    private int currentcoin;

    private Vector3 InitialPosition;
    public Text cointext;

    public void GetCoins(int cointAmount)
    {
        currentNumberOfCoins += cointAmount;
        if (cointext != null)
        {
            cointext.text = currentNumberOfCoins.ToString();
        }
        else
        {
            Debug.LogError("acuerdate de pasar el objeto en unity");
        }
        Debug.Log("pastuki fresca. Mozaa mira cuanta pasta tengo: " + currentNumberOfCoins + "Pastuki");
    }
}