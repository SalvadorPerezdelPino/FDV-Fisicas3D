using UnityEngine;

public class ChangeColorItem : MonoBehaviour
{

    public Material materialToChange;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Player"))
        {
            MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
            meshRenderer.material = materialToChange;
            Debug.Log(this.name);
        }
    }
}
