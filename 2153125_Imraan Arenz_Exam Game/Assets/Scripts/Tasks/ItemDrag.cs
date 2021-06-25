using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrag : MonoBehaviour
{
    Vector3 mousedragoffset;
    public Camera ScreenCamera;
    public bool isScanned;
    public ItemScanHandler OverallScanHandler;
    public Collider2D ScanCol;
    public Collider2D BagCol;


    private void Awake()
    {
       ScreenCamera = Camera.main;
    }

    private void Start()
    {
        isScanned = false;
    }
    void OnMouseDown()
    {
        mousedragoffset = transform.position - MousePos();
    }
    void OnMouseDrag()
    {
        transform.position = MousePos() + mousedragoffset;
        Debug.Log("Dragging");

        if (ScanCol.gameObject.tag =="Scanner")
        {
            StartCoroutine(ScanItem());
        }
    }

    void OnMouseUp()
    {
        if (BagCol.gameObject.tag == "Bag" && isScanned)
        {
            OverallScanHandler.NoOfItemsScanned++;
            this.gameObject.SetActive(false);
        }
        else
        {
            this.gameObject.SetActive(true);
        }
    }

    Vector3 MousePos()
    {
        var MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        MousePosition.z = 0;
        return MousePosition;
    }

    /*private void OnTriggerStay2D(Collider2D ScanTill)
    {
        if (ScanTill.gameObject.CompareTag("Scanner"))
        {
            StartCoroutine(ScanItem());
        }
    }*/

    public IEnumerator ScanItem()
    {
        Debug.Log("Scannin");
        yield return new WaitForSeconds(2f);

        isScanned = true;
    }

    private void OnTriggerEnter2D(Collider2D Bag)
    {
        if (Bag.gameObject.CompareTag("Bag") && isScanned)
        {
            OverallScanHandler.NoOfItemsScanned++;
            Destroy(this.gameObject);
        }
    }
}
