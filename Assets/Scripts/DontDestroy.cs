using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    public string playerTag = "Player"; // Set this to the tag you've assigned to your player GameObjects

    private void Awake()
    {
        // Find all GameObjects with the specified tag
        GameObject[] players = GameObject.FindGameObjectsWithTag(playerTag);
        DontDestroyOnLoad(players[0]);            
          
    }
}
