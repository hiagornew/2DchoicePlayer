using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPanelParts : MonoBehaviour
{
    // Start is called before the first frame update
    public static ControlPanelParts CP;
    public GameObject[] panelParts;


    private void Start()
    {
        //Usamos a variavel static para poder acessar o array de qualquer outro script
        if(ControlPanelParts.CP == null)
        {
            ControlPanelParts.CP = this;
        }
    }

    //A função SelectObjectActive pega como paremetro o nome do Painel, para quando ele clicar no painel, ativar aquele e desativar o outro
    public void SelectObjectActive(string name)
    {
        switch (name)
        {
            case "Head":
                for (int i = 0; i < panelParts.Length; i++)
                {
                    if (panelParts[i].name == "PartsHead")
                    {
                        panelParts[i].SetActive(true);
                    }
                    else
                    {
                        panelParts[i].SetActive(false);
                    }
                }
                break;

            case "Body":
                for (int i = 0; i < panelParts.Length; i++)
                {
                    if (panelParts[i].name == "PartsBody")
                    {
                        panelParts[i].SetActive(true);
                    }
                    else
                    {
                        panelParts[i].SetActive(false);
                    }
                }
                break;

            case "ArmUpper":
                for (int i = 0; i < panelParts.Length; i++)
                {
                    if (panelParts[i].name == "PartsArmLeftUpper")
                    {
                        panelParts[i].SetActive(true);
                    }
                    else
                    {
                        panelParts[i].SetActive(false);
                    }
                }
                break;

            case "ArmBotton":
                for (int i = 0; i < panelParts.Length; i++)
                {
                    if (panelParts[i].name == "PartsArmLeftBotton")
                    {
                        panelParts[i].SetActive(true);
                    }
                    else
                    {
                        panelParts[i].SetActive(false);
                    }
                }
                break;

            case "ArmUpperR":
                for (int i = 0; i < panelParts.Length; i++)
                {
                    if (panelParts[i].name == "PartsArmRigthUpper")
                    {
                        panelParts[i].SetActive(true);
                    }
                    else
                    {
                        panelParts[i].SetActive(false);
                    }
                }
                break;

            case "ArmBottonR":
                for (int i = 0; i < panelParts.Length; i++)
                {
                    if (panelParts[i].name == "PartsArmRigthBotton")
                    {
                        panelParts[i].SetActive(true);
                    }
                    else
                    {
                        panelParts[i].SetActive(false);
                    }
                }
                break;

            case "LegLeft":
                for (int i = 0; i < panelParts.Length; i++)
                {
                    if (panelParts[i].name == "PartsLegLeft")
                    {
                        panelParts[i].SetActive(true);
                    }
                    else
                    {
                        panelParts[i].SetActive(false);
                    }
                }
                break;

            case "LegRigth":
                for (int i = 0; i < panelParts.Length; i++)
                {
                    if (panelParts[i].name == "PartsLegRigth")
                    {
                        panelParts[i].SetActive(true);
                    }
                    else
                    {
                        panelParts[i].SetActive(false);
                    }
                }
                break;
        }
    }
}
