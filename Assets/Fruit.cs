using UnityEngine;

public class Fruit : MonoBehaviour
{
    private string inTheDrop = "y"; // Changed variable name to follow C# naming conventions

    void Update()
    {
        if (InTheDrop == "y")
        {
            // Check if the fruit is in the drop
            transform.position = Drop.dropxPos;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // When space is pressed, activate gravity and reset drop status
            GetComponent<Rigidbody2D>().gravityScale = 1;
            InTheDrop = "n";
            Drop.ResetSpawnedYet();
        }
    }

    // Encapsulate the variable to ensure proper access
    public string InTheDrop
    {
        get { return inTheDrop; }
        set { inTheDrop = value; }
    }
}
