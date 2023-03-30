using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingToggle : MonoBehaviour
{
    public GameObject craftingCanvas;
    public bool craftingOn; 
    
    // Start is called before the first frame update
    void Start()
    {
        craftingOn = false;
        craftingCanvas.SetActive(false);

        GetComponent<FirstPersonLook>().enabled = true;

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

                GetComponent<FirstPersonLook>().enabled = false;
            } else
            {
                craftingOn = false; 
                craftingCanvas.SetActive(false);

                GetComponent<FirstPersonLook>().enabled = true;
            }
        }
    }
}
