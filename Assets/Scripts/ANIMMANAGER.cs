using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANIMMANAGER : MonoBehaviour
{

    public GameObject gmb;
    public AnimationClip idle;
    public AnimationClip attack;
    public AnimationClip damage;
    public AnimationClip death;
    public Animation anim;
    private bool customAnimPlaying = false;
    private bool deathcheck = false;

    void Start()
    {
        if (gmb != null)
        {
            if (gameObject.name == "Boss" | gameObject.name == "Player")
            {


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


    public void attackAnim()
    {
        anim.Stop();
        anim.clip = attack;
        anim.Play();
        customAnimPlaying = true;
    }

    public void damageAnim()
    {
        anim.Stop();
        anim.clip = damage;
        anim.Play();
        customAnimPlaying = true;

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
