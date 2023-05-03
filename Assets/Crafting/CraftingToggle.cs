using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingToggle : MonoBehaviour
{
    public GameObject craftingCanvas;
    public GameObject craftingCursor;

    public GameObject firstPersonMoving; 
    public bool isCraftingOn; 
    
    // Start is called before the first frame update
    void Start()
    {
        isCraftingOn = false;
        craftingCanvas.SetActive(isCraftingOn);
        craftingCursor.SetActive(isCraftingOn);

        firstPersonMoving.GetComponent<PlayerMovement>().enabled = true;
        firstPersonMoving.GetComponent<PlayerMovement>().enabled = !isCraftingOn; 

        
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
            if(isCraftingOn == false)
            {
                isCraftingOn = true;
                craftingCanvas.SetActive(isCraftingOn);
                craftingCursor.SetActive(isCraftingOn);

                firstPersonMoving.GetComponent<PlayerMovement>().enabled = !isCraftingOn;

                Cursor.lockState = CursorLockMode.None;
                firstPersonMoving.GetComponent<PlayerMovement>().enabled = !isCraftingOn; 
            } else
            {
                isCraftingOn = false; 
                craftingCanvas.SetActive(isCraftingOn);
                craftingCursor.SetActive(isCraftingOn);

                GetComponent<PlayerMovement>().enabled = !isCraftingOn;

                Cursor.lockState = CursorLockMode.Locked;
                firstPersonMoving.GetComponent<PlayerMovement>().enabled = !isCraftingOn; 
            }
        }
    }
}
