using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetPlayerPeaces : MonoBehaviour
{
    [Header("pieces that the character can use")]
    public Sprite[] bodyimagens;
    public Sprite[] headimagens;
    public Sprite[] armUpperimagens;
    public Sprite[] armBottonimagens;
    public Sprite[] armUpperRimagens;
    public Sprite[] armBottonRimagens;
    public Sprite[] LegLeftimagens;
    public Sprite[] LegRigthimagens;

    [Header("parts the player is using")]
    public SpriteRenderer bodyImagensPlayer;
    public SpriteRenderer headImagensPlayer;
    public SpriteRenderer ArmUpperImagensPlayer;
    public SpriteRenderer ArmBottonImagensPlayer;
    public SpriteRenderer ArmUpperRImagensPlayer;
    public SpriteRenderer ArmBottonRImagensPlayer;
    public SpriteRenderer LegLeftImagensPlayer;
    public SpriteRenderer LegRigthImagensPlayer;



    void Start()
    {
        SetPeaceInit();
    }

    //A função SetPeaceInit pega o nome da imagem salva no computador e busca no array de imagens, encontrando a imagem com o mesmo nome ele seta aquela imagem.
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

        if (PlayerPrefs.HasKey("ArmUpper"))
        {
            string nameSprite = PlayerPrefs.GetString("ArmUpper");
           
            for (int i = 0; i < armUpperimagens.Length; i++)
            {
                if (nameSprite == armUpperimagens[i].name)
                {
                    ArmUpperImagensPlayer.sprite = armUpperimagens[i];
                }
            }
        }

        if (PlayerPrefs.HasKey("ArmBotton"))
        {
            string nameSprite = PlayerPrefs.GetString("ArmBotton");
            for (int i = 0; i < armBottonimagens.Length; i++)
            {
                if (nameSprite == armBottonimagens[i].name)
                {
                    ArmBottonImagensPlayer.sprite = armBottonimagens[i];
                }
            }
        }

        if (PlayerPrefs.HasKey("ArmUpperR"))
        {
            string nameSprite = PlayerPrefs.GetString("ArmUpperR");
            
            for (int i = 0; i < armUpperRimagens.Length; i++)
            {
                if (nameSprite == armUpperRimagens[i].name)
                {
                    ArmUpperRImagensPlayer.sprite = armUpperRimagens[i];
                }
            }
        }

        if (PlayerPrefs.HasKey("ArmBottonR"))
        {
            string nameSprite = PlayerPrefs.GetString("ArmBottonR");
            for (int i = 0; i < armBottonRimagens.Length; i++)
            {
                if (nameSprite == armBottonRimagens[i].name)
                {
                    ArmBottonRImagensPlayer.sprite = armBottonRimagens[i];
                }
            }
        }


        if (PlayerPrefs.HasKey("LegLeft"))
        {
            string nameSprite = PlayerPrefs.GetString("LegLeft");
            for (int i = 0; i < LegLeftimagens.Length; i++)
            {
                if (nameSprite == LegLeftimagens[i].name)
                {
                    LegLeftImagensPlayer.sprite = LegLeftimagens[i];
                }
            }
        }

        if (PlayerPrefs.HasKey("LegRigth"))
        {
            string nameSprite = PlayerPrefs.GetString("LegRigth");
            for (int i = 0; i < LegRigthimagens.Length; i++)
            {
                if (nameSprite == LegRigthimagens[i].name)
                {
                    LegRigthImagensPlayer.sprite = LegRigthimagens[i];
                }
            }
        }
    }

    
}
