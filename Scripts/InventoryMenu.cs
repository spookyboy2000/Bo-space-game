using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InventoryMenu : MonoBehaviour
{
    public static bool InventoryOpened = false;

    public GameObject inventoryOpen;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (InventoryOpened)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        inventoryOpen.SetActive(false);
        Time.timeScale = 1f;
        InventoryOpened = false;
    }

    void Pause()
    {
        inventoryOpen.SetActive(true);
        Time.timeScale = 0f;
        InventoryOpened = true;
    }
    public void LoadInventory()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
