using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public float movespeed;
    public Rigidbody2D Retail;
    public KeyCode InteractForTask;
    public int NoOfTasks;
    bool isHoldingObject;
    public float GrabRayDist;
    public int ItemCounter;
    bool ItemsPacked;
    public TaskInteractable TaskInteract;

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

    private void OnTriggerEnter2D(Collider2D task)
    {
        if (task.gameObject.CompareTag("Task"))
        {
            if (TaskInteract == null) { return; }
            TaskInteract.StartTask(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(TaskInteract != null) { return; }
        TaskInteract.StartTask(false);
    }
    /*public void Interact()
    {
        
    }*/
}
