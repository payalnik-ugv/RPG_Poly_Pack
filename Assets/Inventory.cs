using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Inventory : MonoBehaviour
{
    private int _diamondAmmount;

    public event Action<int> ONCanvasUpdate;

    public void AddDiamond()
    {
        _diamondAmmount++;
        ONCanvasUpdate?.Invoke(_diamondAmmount);
        //Debug.Log(_diamondAmmount);
    }
}
