using UnityEngine;

public class BackgroundLooper : MonoBehaviour
{
    public Transform player; // Assign the Player in the Inspector
    private Transform background1, background2;


    void Start()
    {
        // Get both background objects (ensure this script is on their parent)
        background1 = transform.GetChild(0);
        background2 = transform.GetChild(1);
    }

    void Update()
    {
        // Find the highest background
        Transform highest = (background1.position.y > background2.position.y) ? background1 : background2;
        Transform lowest = (highest == background1) ? background2 : background1;

        // If player moves past the highest background, move the lowest above it
        if (player.position.y > highest.position.y)
        {

            lowest.position = new Vector3(lowest.position.x, 2 * highest.position.y - lowest.position.y, lowest.position.z);

            Transform temp = highest;
            highest = lowest;
            lowest = temp;
        }
    }
}