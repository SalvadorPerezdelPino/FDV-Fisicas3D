using UnityEngine;

public class ChangeColorItem : MonoBehaviour
{

    public Material materialToChange;
    public Rigidbody rb;
    public float speed = 5.0f;
    private bool canMove = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            MoveForward();
        }
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Sphere"))
        {
            ChangeMaterial();
            canMove = true;
        }
    }

    void ChangeMaterial()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = materialToChange;
        Debug.Log(this.name);
    }
    
    void MoveForward()
    {
        rb.MovePosition(transform.position + transform.forward * Time.deltaTime * speed);
    }
}
