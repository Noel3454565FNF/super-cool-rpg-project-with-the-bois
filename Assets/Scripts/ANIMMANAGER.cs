using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ANIMMANAGER : MonoBehaviour
{

    public GameObject gmb;
    [SerializeField] private Animator anim;

    private string prefName = null;


    private float BossAttackTime = 2.27f;
    private float BossDamageTime = 0.25f;
    public float BossDeathTime = 2;

    private float PlayerAttackTime = 0.30f;
    private float PlayerDamageTime = 0.20f;
    private float PlayerDeathTime = 2;


    private bool customAnimPlaying = false;
    private bool deathcheck = false;

    void Start()
    {
        if (gmb != null)
        {
            if (gameObject.name == "Boss" | gameObject.name == "Player")
            {

                prefName = gameObject.name;
                anim.Play("idle");
            }
        }
    }

    public void returntoidle()
    {
        anim.Play("idle");
    }


    public IEnumerator attackAnim()
    {
        anim.Play("attack");
        customAnimPlaying = true;
        if (prefName == "Boss")
        {
            yield return new WaitForSeconds(BossAttackTime);
            returntoidle();
        }
        else
        {
            yield return new WaitForSeconds(PlayerAttackTime);
            returntoidle();
        }


    }

    public IEnumerator damageAnim()
    {
        anim.Play("damage");
        customAnimPlaying = true;
        if (prefName == "Boss")
        {
            yield return new WaitForSeconds(BossDamageTime);
            returntoidle();
        }
        else
        {
            yield return new WaitForSeconds(PlayerDamageTime);
            returntoidle();
        }


    }

    public void deathAnim()
    {
        anim.Play("death");
        customAnimPlaying = true;
        deathcheck = true;
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (customAnimPlaying == true && deathcheck == false)
    //    {
    //        if (anim.isPlaying == false)
    //        {
    //            returntoidle();
    //        }
    //    }
    //    if (customAnimPlaying == true && deathcheck == true)
    //    {
    //        if (anim.isPlaying == false)
    //        {
    //            anim.Stop();
    //        }
    //    }
    //}
}
