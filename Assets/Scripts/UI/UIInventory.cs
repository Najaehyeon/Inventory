using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public GameObject slotPrefab;
    UISlot[] slots;

    public Button backButton;

    public Text userName;
    public Text level;
    public Text description;

    private void Start()
    {
        if (backButton != null)
        {
            backButton.onClick.AddListener(UIManager.Instance.UIMainMenu.OpenMainMenu);
        }

        userName.text = GameManager.Instance.Player.character.UserName;
        level.text = "Lv. " + GameManager.Instance.Player.character.Level.ToString();
        description.text = GameManager.Instance.Player.character.Description;

        InitInventoryUI();
    }

    public void InitInventoryUI()
    {

    }
}
