using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public GameObject panelBaseAttack;
    public GameObject panelManaAttack;
    public PlayerMain mana;
    public TextMeshProUGUI manaText;
    public TextMeshProUGUI healText;

    private void Update()
    {
        manaText.text = mana.mana.ToString();
        healText.text = mana.currentHealthPlayer.ToString();

        if (!(battleSystem.Instance.currentState == battleState.PLAYERTURN))
        {
            panelBaseAttack.SetActive(false);
            panelManaAttack.SetActive(false);
        }
    }

    public void HidePanels()
    {
        panelBaseAttack.SetActive(false);
        panelManaAttack.SetActive(false);
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
