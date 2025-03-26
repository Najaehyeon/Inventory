using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    public Button backButton;

    public Text userName;
    public Text level;
    public Text description;
    public Text atk;
    public Text def;
    public Text hp;
    public Text crit;

    private void Start()
    {
        if (backButton != null)
        {
            backButton.onClick.AddListener(UIManager.Instance.UIMainMenu.OpenMainMenu);
        }

        userName.text = GameManager.Instance.Player.character.UserName;
        level.text = "Lv. " + GameManager.Instance.Player.character.Level.ToString();
        description.text = GameManager.Instance.Player.character.Description;
        atk.text = GameManager.Instance.Player.character.Atk.ToString();
        def.text = GameManager.Instance.Player.character.Def.ToString();
        hp.text = GameManager.Instance.Player.character.Health.ToString();
        crit.text = GameManager.Instance.Player.character.Crit.ToString();
    }
}
