using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPeaces : MonoBehaviour
{
    public SetPlayerPeaces player;

    [Header("parts the player is using")]
    public Image bodyImagensPlayer;
    public Image headImagensPlayer;

    private void Start()
    {
        if (PlayerPrefs.HasKey("Body"))
        {
            string nameSprite = PlayerPrefs.GetString("Body");
            for (int i = 0; i < player.bodyimagens.Length; i++)
            {
                if (nameSprite == player.bodyimagens[i].name)
                {
                    bodyImagensPlayer.sprite = player.bodyimagens[i];
                }
            }
        }

        if (PlayerPrefs.HasKey("Head"))
        {
            string nameSprite = PlayerPrefs.GetString("Head");
            for (int i = 0; i < player.headimagens.Length; i++)
            {
                if (nameSprite == player.headimagens[i].name)
                {
                    headImagensPlayer.sprite = player.headimagens[i];
                }
            }
        }
    }

    public void ChangeBodyImage( Sprite sprite)
    {
        bodyImagensPlayer.sprite = sprite;
        PlayerPrefs.SetString("Body", sprite.name);
        player.SetPeaceInit();
    }

    public void ChangeHeadImage(Sprite sprite)
    {
        headImagensPlayer.sprite = sprite;
        PlayerPrefs.SetString("Head", sprite.name);
        player.SetPeaceInit();
    }
}
