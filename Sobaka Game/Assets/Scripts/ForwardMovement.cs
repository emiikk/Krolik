using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    public float moveSpeed = 1f;
    private Rigidbody rb;
    private float borderZ = 2f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        if (rb == null)
        {
            Debug.Log("No Rigidbody found");
            enabled = false;
        }
    }

    void Update()
    {
        rb.AddForce(transform.forward * moveSpeed, ForceMode.Force);
        if (transform.position.z > borderZ)
        {
            Destroy(gameObject);
        }
    }

    
}
