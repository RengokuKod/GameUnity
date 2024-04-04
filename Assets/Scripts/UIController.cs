using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    public MarioController mario;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI mobText;

    void Update()
    {
        coinText.text = "Coins: " + mario.coinCount;
        mobText.text = "Mobs: " + mario.GetMobCount();
    }
}