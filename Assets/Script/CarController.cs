using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CarMoveZOnly : MonoBehaviour
{
    public float moveSpeed = 8f;

    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();

        
        rb.constraints =
            RigidbodyConstraints.FreezeRotationX |
            RigidbodyConstraints.FreezeRotationZ |
            RigidbodyConstraints.FreezeRotationY |   
            RigidbodyConstraints.FreezePositionY;     
    }

    void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical"); 

        
        Vector3 moveDir = Vector3.forward * v;

        Vector3 targetPos = rb.position + moveDir * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(targetPos);
    }
}