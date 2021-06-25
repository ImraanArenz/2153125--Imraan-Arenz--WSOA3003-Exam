using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTask : MonoBehaviour
{
    public TaskInteractable TaskInteract;
    private void OnTriggerEnter2D(Collider2D task)
    {
        if (task.gameObject.CompareTag("Player"))
        {
            if (TaskInteract == null) { return; }
            TaskInteract.StartTask(true);
        }
    }
}
