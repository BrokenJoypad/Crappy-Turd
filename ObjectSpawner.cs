using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{


    

    [Header("Settings")]
    [SerializeField, Range(0, 10)] float SpawnDelay = 2f;
    [SerializeField] private GameObject ObjectToSpawn;

    private float SpawnDelayTimer = 0f;
    private GameManager gameManager;

    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.Instance;
        SpawnObject();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.ReturnPlayerState())
        {
            SpawnDelayTimer = SpawnDelayTimer += Time.deltaTime;

            if (SpawnDelayTimer >= SpawnDelay)
            {
                SpawnObject();
            }
        }
        
    }

    void SpawnObject()
    {
        Instantiate(ObjectToSpawn, gameObject.transform.position, gameObject.transform.rotation);
        SpawnDelayTimer = 0f;
    }
}
