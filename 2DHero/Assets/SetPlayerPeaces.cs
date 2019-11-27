using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetPlayerPeaces : MonoBehaviour
{
    [Header("pieces that the character can use")]
    public Sprite[] bodyimagens;
    public Sprite[] headimagens;

    [Header("parts the player is using")]
    public SpriteRenderer bodyImagensPlayer;
    public SpriteRenderer headImagensPlayer;



    void Start()
    {
        SetPeaceInit();
    }

    public void SetPeaceInit()
    {
        if (PlayerPrefs.HasKey("Body"))
        {
            string nameSprite = PlayerPrefs.GetString("Body");
            for (int i = 0; i < bodyimagens.Length; i++)
            {
                if(nameSprite == bodyimagens[i].name)
                {
                    bodyImagensPlayer.sprite = bodyimagens[i];
                }
            }
        }

        if (PlayerPrefs.HasKey("Head"))
        {
            string nameSprite = PlayerPrefs.GetString("Head");
            for (int i = 0; i < headimagens.Length; i++)
            {
                if (nameSprite == headimagens[i].name)
                {
                    headImagensPlayer.sprite = headimagens[i];
                }
            }
        }
    }

    
}
