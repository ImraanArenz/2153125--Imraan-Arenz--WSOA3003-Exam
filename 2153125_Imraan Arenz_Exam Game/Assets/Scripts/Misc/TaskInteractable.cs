using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskInteractable : MonoBehaviour
{
    [SerializeField] GameObject Task;


  public void StartTask(bool isTaskActive)
    {
        Task.SetActive(isTaskActive);
    }
}
