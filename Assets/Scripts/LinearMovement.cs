using UnityEngine;

public class LinearMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody rb;

    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
  

        rb.linearVelocity = new Vector3(1f*speed, rb.linearVelocity.y, rb.linearVelocity.z);

    }
}
