using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingToggle : MonoBehaviour
{
    public GameObject craftingCanvas;
    public bool craftingOn; 
    
    public GameObject FirstPersonGrabber; 
    
    // Start is called before the first frame update
    void Start()
    {
        craftingOn = false;
        craftingCanvas.SetActive(false);

        (FirstPersonGrabber.GetComponent("FirstPersonCamera") as MonoBehaviour).enabled = true; 
    }

    // Update is called once per frame
    void Update()
    {
        toggleMenuCheck();
    }

    void toggleMenuCheck()
    {
        if (Input.GetKeyDown("i")) //Can change to different key based on what we decide
        {
            Debug.Log("Toggling Crafting/Inventory.");
            if(craftingOn == false)
            {
                craftingOn = true;
                craftingCanvas.SetActive(true);

                (FirstPersonGrabber.GetComponent("First Person Camera") as MonoBehaviour).enabled = false; 
            } else
            {
                craftingOn = false; 
                craftingCanvas.SetActive(false);

                (FirstPersonGrabber.GetComponent("First Person Camera") as MonoBehaviour).enabled = true; 
            }
        }
    }
}
