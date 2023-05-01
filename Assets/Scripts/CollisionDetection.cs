using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public string Object = "Obstacle";
    public Player_Movement movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        // Debug.Log(collisionInfo.collider.name);
        if (collisionInfo.collider.tag == Object)
        {
            Debug.Log("Obstacle Hit");
            movement.enabled = false;
            // GetComponent<Player_Movement>().enabled = false;         exact same thing as the above
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
