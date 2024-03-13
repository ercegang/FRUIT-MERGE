using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public bool isMerging;
    public GameObject nextFruit;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.CompareTag("Fruit")) return;
        if (isMerging) return;
        if (GetComponent<SpriteRenderer>().color != other.gameObject.GetComponent<SpriteRenderer>().color) return;
        other.gameObject.GetComponent<Fruit>().isMerging = true;
            Destroy(gameObject);
            Destroy(other.gameObject);

        Instantiate(nextFruit, transform.position, Quaternion.identity);     
        
    }
}
