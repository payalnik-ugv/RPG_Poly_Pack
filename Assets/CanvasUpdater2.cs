//using TMPro;
//using UnityEngine;

//public class CanvasUpdater2 : MonoBehaviour
//{

//    [SerializeField] private Inventory inventory;
//    [SerializeField] private TMP_Text goldTextAmmount;

//    private void OnEnable()
//    {
//        inventory.ONCanvasUpdate += InventoryOnCanvasUpdate;
//    }

//    private void OnDisable()
//    {
//        inventory.ONCanvasUpdate -= InventoryOnCanvasUpdate;
//    }

//    private void InventoryOnCanvasUpdate(int ammountGolds)
//    {
//        goldTextAmmount.text = ammountGolds.ToString();
//    }
//}
