using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onOverMegaAttack : MonoBehaviour
{
    public GameObject panelAttack1;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("cursor"))
        {
            panelAttack1.SetActive(true);

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        panelAttack1.SetActive(false);

    }
}
