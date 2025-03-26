using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [SerializeField] private UIMainMenu uiMainMenu;
    public UIMainMenu UIMainMenu { get; private set; }

    [SerializeField] private UIStatus uiStatus;
    public UIStatus UIStatus { get; private set; }

    [SerializeField] private UIInventory uiInventory;
    public UIInventory UIInventory { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

            UIMainMenu = uiMainMenu;
            UIStatus = uiStatus;
            UIInventory = uiInventory;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }
}
