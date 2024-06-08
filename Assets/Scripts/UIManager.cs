using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject panelBaseAttack;
    public GameObject panelManaAttack;


    public void OnClickPanelBase()
    {
        panelBaseAttack.SetActive(true);
        panelManaAttack.SetActive(false);

    }
    public void OnClickPanelMana()
    {
        panelBaseAttack.SetActive(false);
        panelManaAttack.SetActive(true);

    }
}
