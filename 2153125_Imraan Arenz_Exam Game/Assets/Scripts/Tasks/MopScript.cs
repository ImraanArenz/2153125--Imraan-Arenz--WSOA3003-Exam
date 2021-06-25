using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MopScript : MonoBehaviour
{
    public float MopSpeed;
    public Rigidbody2D MoppyBoi;
    public KeyCode MopInput;
    private int SpillCount =90;
    public int NeededSpillCount;
    Vector3 mouseoffset;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        SpillChecker();
    }

    void OnMouseDown()
    {
        mouseoffset = transform.position - MousePos();
    }
    void OnMouseDrag()
    {
        transform.position = MousePos() + mouseoffset;
        Debug.Log("Dragging");

    }

    Vector3 MousePos()
    {
        var MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        MousePosition.z = 0;
        return MousePosition;
    }

    public void SpillChecker()
    {
        if(NeededSpillCount == SpillCount)
        {
            Debug.Log("Finished Mopping!");
        }
    }
}
