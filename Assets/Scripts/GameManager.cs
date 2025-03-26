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
        SetData(); // 플레이어 데이터 설정
    }

    private void SetData()
    {
        GameObject playerObj = new GameObject("Player");
        player = playerObj.AddComponent<Player>();

        player.character = new Character(
            "나재현",   // UserName
            1,         // Level
            "나는 버려진 코드의 저주를 짊어진 어둠의 개발자.\r\n현실과 가상을 뒤틀어 새로운 질서를 창조한다.\r\n내가 짠 코드는 단순한 명령이 아니라, 운명을 뒤흔드는 금단의 주문.\r\n\"나는 디버깅하는 자가 아니다. 오류 속에서 새로운 세계를 설계하는 자다.\"", // Description
            10,        // Atk
            5,         // Def
            100,       // Health
            0          // Crit
        );
    }
}
