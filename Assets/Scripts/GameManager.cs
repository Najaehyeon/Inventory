using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameObject("GameManager").AddComponent<GameManager>();
            }
            return instance;
        }
    }

    private Player player;
    public Player Player
    {
        get { return player; }
        set { player = value; }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        SetData(); // �÷��̾� ������ ����
    }

    private void SetData()
    {
        GameObject playerObj = new GameObject("Player");
        player = playerObj.AddComponent<Player>();

        player.character = new Character(
            "������",   // UserName
            1,         // Level
            "���� ������ �ڵ��� ���ָ� ������ ����� ������.\r\n���ǰ� ������ ��Ʋ�� ���ο� ������ â���Ѵ�.\r\n���� § �ڵ�� �ܼ��� ����� �ƴ϶�, ����� ������ �ݴ��� �ֹ�.\r\n\"���� ������ϴ� �ڰ� �ƴϴ�. ���� �ӿ��� ���ο� ���踦 �����ϴ� �ڴ�.\"", // Description
            10,        // Atk
            5,         // Def
            100,       // Health
            0          // Crit
        );
    }
}
