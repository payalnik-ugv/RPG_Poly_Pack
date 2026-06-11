using UnityEngine;
using System;

public class Inventory : MonoBehaviour
{
    private int _diamondAmmount;
    private int _goldAmmount;

    public event Action<int,int> ONCanvasUpdate;

    public void AddResource(Resource resource)
    {
        switch (resource)
        {
            case Resource.Diamond:
                _diamondAmmount++;
                break;
            case Resource.Gold:
                _goldAmmount++;
                break;
        }
        ONCanvasUpdate?.Invoke(_diamondAmmount, _goldAmmount);
    }
}
