using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public float movespeed;
    public Rigidbody2D Retail;
    public KeyCode InteractForTask;
    public int NoOfCompletedTasks;
    public int NoOfTasks;
    bool isHoldingObject;
    public float GrabRayDist;
    public int ItemCounter;
    bool ItemsPacked;
    public TaskInteractable TaskInteract;
    public TaskInteractable TaskInteract2;
    public TaskInteractable TaskInteract3;
    public PunchActivateScript PunchActive;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        float MoveX = Input.GetAxis("Horizontal");
        float MoveY = Input.GetAxis("Vertical");

        Vector3 Move = Retail.velocity;
        Retail.velocity = new Vector3(MoveX * movespeed, MoveY * movespeed, 0f);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(TaskInteract != null) { return; }
        TaskInteract.StartTask(false);
    }

    private void OnTriggerEnter2D(Collider2D task)
    {
        if (task.gameObject.CompareTag("Task"))
        {
            if (TaskInteract == null) { return; }
            TaskInteract.StartTask(true);
        }
        else if(task.gameObject.CompareTag("Task 2"))
        {
            if (TaskInteract2 == null) { return; }
            TaskInteract2.StartTask(true);
        }
        else if (task.gameObject.CompareTag("Task 3"))
        {
            if (TaskInteract3 == null) { return; }
            TaskInteract3.StartTask(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D pun)
    {
        if (pun.gameObject.CompareTag("Punch"))
        {
            if(PunchActive == null) { return; }
            PunchActive.StartTask(true);
        }
    }
}
