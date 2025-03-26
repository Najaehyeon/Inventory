using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    public Button statusButton;
    public Button inventoryButton;

    UIManager uiManager;

    public Text userName;
    public Text level;
    public Text description;

    private void Start()
    {
        uiManager = UIManager.Instance;

        if (statusButton != null && inventoryButton != null)
        {
            statusButton.onClick.AddListener(OpenStatus);
            inventoryButton.onClick.AddListener(OpenInventory);
        }

        userName.text = GameManager.Instance.Player.character.UserName;
        level.text = "Lv. " + GameManager.Instance.Player.character.Level.ToString();
        description.text = GameManager.Instance.Player.character.Description;
    }

    public void OpenMainMenu()
    {
        uiManager.UIInventory.gameObject.SetActive(false);
        uiManager.UIStatus.gameObject.SetActive(false);
        uiManager.UIMainMenu.gameObject.SetActive(true);
    }

    public void OpenStatus()
    {
        uiManager.UIMainMenu.gameObject.SetActive(false);
        uiManager.UIStatus.gameObject.SetActive(true);
    }

    public void OpenInventory()
    {
        uiManager.UIMainMenu.gameObject.SetActive(false);
        uiManager.UIInventory.gameObject.SetActive(true);
    }
}
