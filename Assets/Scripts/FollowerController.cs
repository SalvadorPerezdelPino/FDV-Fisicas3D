using UnityEngine;

public class FollowerController : MonoBehaviour
{
    public Transform target;
    public Rigidbody rb;
    public float force = 10.0f;
    private Vector3 direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = target.position - this.transform.position;
        if (direction.magnitude > 0.001f)
        {
            rb.AddForce(direction.normalized * force);
        }
    }
}
