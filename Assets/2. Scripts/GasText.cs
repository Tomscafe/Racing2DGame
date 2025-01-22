using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GasText : MonoBehaviour
{
    public TextMeshProUGUI gasText;
    void Update()
    {
        gasText.text = "Gas : " + PlayerController.playerGas;
    }
}
