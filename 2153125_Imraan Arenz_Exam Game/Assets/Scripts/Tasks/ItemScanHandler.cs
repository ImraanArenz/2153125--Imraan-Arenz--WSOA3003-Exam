using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScanHandler : MonoBehaviour
{
    public int ScannedItems;
    public int NoOfItemsScanned;
    bool TaskCompleted;
    public GameObject dragTask;
    public PlayerScript playerCount;

    private void Start()
    {
        TaskCompleted = false;
    }
    void Update()
    {
        if(NoOfItemsScanned == ScannedItems)
        {
            TaskCompleted = true;
            playerCount.NoOfCompletedTasks++;
            dragTask.SetActive(false);
        }
    }
}
