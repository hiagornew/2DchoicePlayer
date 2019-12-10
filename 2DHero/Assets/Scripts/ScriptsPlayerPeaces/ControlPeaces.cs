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
    public Image ArmUpperImagensPlayer;
    public Image ArmBottonImagensPlayer;
    public Image ArmUpperRImagensPlayer;
    public Image ArmBottonRImagensPlayer;
    public Image LegLeftPlayer;
    public Image LegRigthPlayer;

    //No Método Start nós pegamos o nome da imagem salva no computador, procuramos ela no array e setamos no personagem
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

        if (PlayerPrefs.HasKey("ArmUpper"))
        {
            string nameSprite = PlayerPrefs.GetString("ArmUpper");
            for (int i = 0; i < player.armUpperimagens.Length; i++)
            {
                if (nameSprite == player.armUpperimagens[i].name)
                {
                    ArmUpperImagensPlayer.sprite = player.armUpperimagens[i];
                }
            }
        }

        if (PlayerPrefs.HasKey("ArmBotton"))
        {
            string nameSprite = PlayerPrefs.GetString("ArmBotton");
            for (int i = 0; i < player.armBottonimagens.Length; i++)
            {
                if (nameSprite == player.armBottonimagens[i].name)
                {
                    ArmBottonImagensPlayer.sprite = player.armBottonimagens[i];
                }
            }
        }

        if (PlayerPrefs.HasKey("ArmUpperR"))
        {
            string nameSprite = PlayerPrefs.GetString("ArmUpperR");
            for (int i = 0; i < player.armUpperRimagens.Length; i++)
            {
                if (nameSprite == player.armUpperRimagens[i].name)
                {
                    ArmUpperRImagensPlayer.sprite = player.armUpperRimagens[i];
                }
            }
        }

        if (PlayerPrefs.HasKey("ArmBottonR"))
        {
            string nameSprite = PlayerPrefs.GetString("ArmBottonR");
            for (int i = 0; i < player.armBottonRimagens.Length; i++)
            {
                if (nameSprite == player.armBottonRimagens[i].name)
                {
                    ArmBottonRImagensPlayer.sprite = player.armBottonRimagens[i];
                }
            }
        }


        if (PlayerPrefs.HasKey("LegLeft"))
        {
            string nameSprite = PlayerPrefs.GetString("LegLeft");
            for (int i = 0; i < player.LegLeftimagens.Length; i++)
            {
                if (nameSprite == player.LegLeftimagens[i].name)
                {
                    LegLeftPlayer.sprite = player.LegLeftimagens[i];
                }
            }
        }

        if (PlayerPrefs.HasKey("LegRigth"))
        {
            string nameSprite = PlayerPrefs.GetString("LegRigth");
            for (int i = 0; i < player.LegRigthimagens.Length; i++)
            {
                if (nameSprite == player.LegRigthimagens[i].name)
                {
                    LegRigthPlayer.sprite = player.LegRigthimagens[i];
                }
            }
        }


    }

    //Os Metodos Change... Servem para toda vez que clicar em alguma imagem de peça ela trocar a peça que o personagem está usando e salvar a peça nova
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

    public void ChangeArmUpperImage(Sprite sprite)
    {
        ArmUpperImagensPlayer.sprite = sprite;
        PlayerPrefs.SetString("ArmUpper", sprite.name);
        player.SetPeaceInit();
    }

    public void ChangeArmBottonImage(Sprite sprite)
    {
        ArmBottonImagensPlayer.sprite = sprite;
        PlayerPrefs.SetString("ArmBotton", sprite.name);
        player.SetPeaceInit();
    }


    public void ChangeArmUpperRImage(Sprite sprite)
    {
        ArmUpperRImagensPlayer.sprite = sprite;
        PlayerPrefs.SetString("ArmUpperR", sprite.name);
        player.SetPeaceInit();
    }

    public void ChangeArmBottonRImage(Sprite sprite)
    {
        ArmBottonRImagensPlayer.sprite = sprite;
        PlayerPrefs.SetString("ArmBottonR", sprite.name);
        player.SetPeaceInit();
    }

    public void ChangeLegLeftImage(Sprite sprite)
    {
        LegLeftPlayer.sprite = sprite;
        PlayerPrefs.SetString("LegLeft", sprite.name);
        player.SetPeaceInit();
    }

    public void ChangeLegRigthImage(Sprite sprite)
    {
        LegRigthPlayer.sprite = sprite;
        PlayerPrefs.SetString("LegRigth", sprite.name);
        player.SetPeaceInit();
    }
}
