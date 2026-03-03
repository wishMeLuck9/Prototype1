using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player; // Reference to the player GameObject

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(0, 5, -7); // Set the position of this GameObject to the player's position
    }
}
