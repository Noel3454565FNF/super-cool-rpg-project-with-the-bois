using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject panelBaseAttack;
    public GameObject panelManaAttack;
    public PlayerMain mana;
    public TextMeshProUGUI manaText;

    private void Update()
    {
        manaText.text = mana.mana.ToString();
    }

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
