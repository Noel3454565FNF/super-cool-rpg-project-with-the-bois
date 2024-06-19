using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit : MonoBehaviour
{
    public void QTE_Return(bool success, bool WasAnAttack)
    {
        if (WasAnAttack)
        {
            Debug.Log("Attack multiplied : " +  success);
        }
        else
        {
            Debug.Log("Dodged : " + success);
        }
    }

    public void Attack()
    {
        QTE.instance.LaunchQTE(this, true, 2, 0.7f, 0.4f);
    }

    public void Dodge()
    {
        QTE.instance.LaunchQTE(this, false, 1.5f, 0.7f, 0.3f);
    }
}
