using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScanHandler : MonoBehaviour
{
    public int ScannedItems;
    public int NoOfItemsScanned;
    bool TaskCompleted;

    private void Start()
    {
        TaskCompleted = false;
    }
    void Update()
    {
        if(NoOfItemsScanned == ScannedItems)
        {
            TaskCompleted = true;
        }
    }
}
