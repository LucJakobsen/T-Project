using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn; // Assign your prefab to this in the inspector
    public Vector3 locationToSpawnAt; // Set the specific location where the object will be spawned
    public Vector3 sizeToSpawnWith; // Set the specific size for the spawned object
    public Vector3 rotationToSpawnWith; // Set the specific rotation for the spawned object as Euler angles

    // Call this method when the button is clicked
    public void SpawnObject()
    {
        // Instantiate the object at the specified location with the specified rotation
        GameObject spawnedObject = Instantiate(objectToSpawn, locationToSpawnAt, Quaternion.Euler(rotationToSpawnWith));

        // Set the size of the object using localScale
        spawnedObject.transform.localScale = sizeToSpawnWith;
    }
}
