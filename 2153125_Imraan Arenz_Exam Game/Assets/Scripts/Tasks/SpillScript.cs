using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpillScript : MonoBehaviour
{
    public MopScript Spills;
    public void OnTriggerExit2D(Collider2D clean)
    {
        if (clean.gameObject.CompareTag("Player"))
        {
            Spills.NeededSpillCount++;
            Destroy(this.gameObject);
        }
    }
}
