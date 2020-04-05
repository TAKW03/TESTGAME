using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float PlayerSpeed = 500f;

    public float sidewaysforce = 500f;

    void Start()
    {
        Debug.Log("GAME START!");
    }

    
    void FixedUpdate()
    {

        rb.AddForce(0, 0, PlayerSpeed * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0);
        }

    }
}
