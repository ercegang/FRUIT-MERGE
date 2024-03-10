using UnityEngine;

public class Drop : MonoBehaviour
{
    public GameObject[] fruitObj; // Array of fruit prefabs
    public static string spawnedYet = "n"; // Change accessibility to public static
    public static Vector3 dropxPos; // Add public static Vector3 field to hold drop position

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SpawnFruit();
    }

    void SpawnFruit()
    {
        if (spawnedYet == "n")
        {
            // Instantiate a fruit object at the drop position
            GameObject fruit = Instantiate(fruitObj[Random.Range(0, fruitObj.Length)], transform.position, Quaternion.identity);
            fruit.GetComponent<Fruit>().InTheDrop = "y";
            spawnedYet = "y";
        }
    }

    public static void ResetSpawnedYet()
    {
        spawnedYet = "n";
    }
}
