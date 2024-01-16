using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingMaterial : MonoBehaviour
{
    // Start is called before the first frame update
    public Material goodM, badM;
    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        if (SceneManager.GetActiveScene().name == "bad")
        {
            //renderer.material = badM;
        }
        else
        {
            Material[] materials = renderer.materials;

            // Iterate through the materials to find and replace "Drywall_A"
            for (int i = 0; i < materials.Length; i++)
            {
                
                if (materials[i].ToString().Contains("Drywall_A"))
                {
                    materials[i] = goodM; // Replace with "Drywall_A clean"
                }
            }

            // Assign the modified materials array back to the renderer
            renderer.materials = materials; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
