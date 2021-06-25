using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchActivateScript : MonoBehaviour
{
    [SerializeField] GameObject Task;
    public PlayerScript playerboi;

    public void StartTask(bool isTaskActive)
    {
        if(playerboi.NoOfCompletedTasks == playerboi.NoOfTasks)
        {
            Task.SetActive(isTaskActive);
        }
    }
}
