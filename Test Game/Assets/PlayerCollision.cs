using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    void OnCollisionEnter(Collision collosioninfo)
    {
        if (collosioninfo.collider.tag == "Obstical")
        {
            movement.enabled = false;
        }
    }
  
}
