using System;
using UnityEngine;
using TMPro;

public class CanvasUpdater : MonoBehaviour
{
    [SerializeField]
    private Inventory inventory;

    [SerializeField] 
    private TMP_Text diamondTextAmmount;

    // Start is called before the first frame update
    void Start()
    {
        inventory.ONCanvasUpdate += InvertoryOnONCanvasUpdate;
    }

    private void InvertoryOnONCanvasUpdate(int diamondAmmount)
    {
        diamondTextAmmount.text = diamondAmmount.ToString();
    }
}
