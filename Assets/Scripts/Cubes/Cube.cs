using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private Rigidbody rb;
    private float velocity;
    private float distance;

    public float Velocity { get => velocity; set => velocity = value; }
    public float Distance { get => distance; set => distance = value; }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(velocity,0,0);
        StartCoroutine(WaitForDistance());

    }
    private IEnumerator WaitForDistance()
    {
        float time = distance / velocity;
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
    
    
}
