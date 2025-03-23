using UnityEngine;
using System.Collections.Generic;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab;
    public int numPlatforms = 10;
    public float levelWidth = 50f;
    public float minY = 0.5f;
    public float maxY = 1.5f;

    private float highestY;
    private List<GameObject> spawnedPlatforms = new List<GameObject>();
    public float destroyHeightOffset = 10f;

    void Start()
    {
        // Start spawning based on camera position
        highestY = Camera.main.transform.position.y - 3f; // -3f bc they were spawning a lil too high
        for (int i = 0; i < numPlatforms; i++)
        {
            SpawnPlatform();
        }
    }

    void SpawnPlatform()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-levelWidth, levelWidth), highestY + Random.Range(minY, maxY), 0f);
        GameObject newPlatform = Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        spawnedPlatforms.Add(newPlatform);
        highestY = spawnPosition.y;
    }

    void Update()
    {
        // Ensure new platforms spawn above the screen
        if (Camera.main.transform.position.y + 5 > highestY)
        {
            SpawnPlatform();
        }

        // Destroy platforms that are below the camera
        for (int i = spawnedPlatforms.Count - 1; i >= 0; i--)
        {
            if (spawnedPlatforms[i] != null && spawnedPlatforms[i].transform.position.y < Camera.main.transform.position.y - destroyHeightOffset)
            {
                Destroy(spawnedPlatforms[i]);
                spawnedPlatforms.RemoveAt(i);
            }
        }
    }
}