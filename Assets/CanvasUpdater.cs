using UnityEngine;
using TMPro;

public class CanvasUpdater : MonoBehaviour
{
    [SerializeField] private Inventory inventory;
    [SerializeField] private TMP_Text diamondTextAmmount;
    [SerializeField] private TMP_Text goldTextAmmount;

    // Start is called before the first frame update
    void Start()
    {
        inventory.ONCanvasUpdate += InvertoryOnONCanvasUpdate;
    }

    // Called when a component itself is disabled or its parent GameObject is deactivated
    void OnDisable()
    {
        inventory.ONCanvasUpdate -= InvertoryOnONCanvasUpdate;
    }

    private void InvertoryOnONCanvasUpdate(int diamondAmmount, int goldAmmount)
    {
        diamondTextAmmount.text = diamondAmmount.ToString();
        goldTextAmmount.text = goldAmmount.ToString();
    }
}
