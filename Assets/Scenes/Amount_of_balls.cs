using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectCounter : MonoBehaviour
{
    [Tooltip("Tag of objects to track.")]
    public string targetTag = "Eye_of_doom";

    [Tooltip("Name of the scene to load when count reaches zero.")]
    public string sceneToLoad = "1";

    private void Update()
    {
        // Find all objects with the target tag
        GameObject[] objects = GameObject.FindGameObjectsWithTag(targetTag);

        // If none are left, load the new scene
        if (objects.Length == 0)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}


