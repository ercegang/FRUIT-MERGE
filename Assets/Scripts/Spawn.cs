using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Pointer;
    public GameObject Small;
    public GameObject MediumPrefab;
    public GameObject LargePrefab;

    public Vector2 PointerPosition;
    public float CurrentBall;
    public float NextBall;

    public GameObject FakeSmall;
    public GameObject FakeMedium;
    public GameObject FakeLarge;

    public GameObject NextSmall;
    public GameObject NextMediumSmall;
    public GameObject NextLarge;


    private void Start()
    {
      

        CurrentBall = Random.Range(0f, 100f);
        NextBall = Random.Range(0f, 100f);
        
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PointerPosition = Pointer.transform.position;

            SpawnRandomBall();
            
        }
    }

    public void SpawnRandomBall()
    {
        Vector2 spawnPosition = new Vector3(PointerPosition.x, PointerPosition.y);

        if (CurrentBall <= 60f)
        {
            Instantiate(Small, spawnPosition, Quaternion.identity);
        }
        else if (CurrentBall <= 85f)
        {
            Instantiate(MediumPrefab, spawnPosition, Quaternion.identity);
        }
        else
        {
            Instantiate(LargePrefab, spawnPosition, Quaternion.identity);
        }
        UpdateBallValues();
    }

    private void UpdateBallValues()
    {
        CurrentBall = NextBall;
        NextBall = Random.Range(0f, 100f);
    }

   
    }

   

   

