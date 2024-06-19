using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ANIMMANAGER : MonoBehaviour
{

    public GameObject gmb;
    public AnimationClip idle;
    public AnimationClip attack;
    public AnimationClip damage;
    public AnimationClip death;
    public Animation anim;

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
                anim.clip = idle;
                anim.Play();
            }
        }
    }


    public void returntoidle()
    {
        anim.Stop();
        anim.clip = idle;
        anim.Play();
    }


    public IEnumerator attackAnim()
    {
        //Debug.Log("attack boss");
        anim.Stop();
        anim.clip = attack;
        anim.Play();
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
        anim.Stop();
        anim.clip = damage;
        anim.Play();
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
        anim.Stop();
        anim.clip = death;
        anim.Play();
        customAnimPlaying = true;
        deathcheck = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (customAnimPlaying == true && deathcheck == false)
        {
            if (anim.isPlaying == false)
            {
                returntoidle();
            }
        }
        if (customAnimPlaying == true && deathcheck == true)
        {
            if (anim.isPlaying == false)
            {
                anim.Stop();
            }
        }
    }
}
