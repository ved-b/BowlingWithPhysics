using UnityEngine;

public class Gutter : MonoBehaviour
{

    private void OnTriggerEnter(Collider triggeredBody){
        Rigidbody ballRigidBody = triggeredBody.GetComponent<Rigidbody>();

        float velocityMagnitude = ballRigidBody.linearVelocity.magnitude;

        ballRigidBody.linearVelocity = Vector3.zero;

        ballRigidBody.AddForce(transform.forward * velocityMagnitude, ForceMode.VelocityChange);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Testing if this is the right branch being tracked
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
