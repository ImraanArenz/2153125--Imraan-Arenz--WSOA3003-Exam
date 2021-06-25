using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PunchInScript : MonoBehaviour
{
    public Rigidbody2D thumb;
    public float ThumbSpeed;
    public GameObject Light;
    

    void Start()
    {
        Light.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        MoveThumb();
    }

    public void MoveThumb()
    {
        float ThumbX = Input.GetAxis("Horizontal");
        float ThumbY = Input.GetAxis("Vertical");

        Vector3 ThumbMovement = thumb.velocity;
        thumb.velocity = new Vector3(ThumbX * ThumbSpeed, ThumbY * ThumbSpeed, transform.position.z);
    }

    private void OnTriggerStay2D(Collider2D scan)
    {
        if (scan.gameObject.CompareTag("Scanner"))
        {
            Debug.Log("Scanning");
            StartCoroutine(Scan());
            
        }
    }

    public IEnumerator Scan()
    {
        yield return new WaitForSeconds(5f);

        Light.SetActive(true);
        Debug.Log("Finish Scan");
        Invoke("EndGame", 0.5f);
    }

    public void EndGame()
    {
        SceneManager.LoadScene("Game Over");
    }
}
