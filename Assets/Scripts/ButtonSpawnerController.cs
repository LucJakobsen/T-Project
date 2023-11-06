using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonSpawnerController : MonoBehaviour
{
    public Button button; // The button to interact with
    public GameObject objectToSpawn; // The object prefab to spawn
    public TextMeshProUGUI associatedText; // The associated TMP text to strikethrough
    public Vector3 spawnLocation; // Location to spawn the object at
    public Vector3 spawnScale; // Scale to spawn the object with
    public Vector3 spawnRotation; // Rotation to spawn the object with

    void Start()
    {
        // Add the OnButtonClick method to the button's click event
        button.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        // Spawn the object
        Instantiate(objectToSpawn, spawnLocation, Quaternion.Euler(spawnRotation)).transform.localScale = spawnScale;
        
        // Strikethrough the text
        associatedText.fontStyle = FontStyles.Strikethrough;

        // Disable the button
        button.interactable = false;
    }
}
