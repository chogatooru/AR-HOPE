using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HopeValue_Management : MonoBehaviour
{
    public int Hope = 100;
    public int HopeMax = 100;
    SpriteRenderer spriteR;
    public Sprite[] HopeSprites;
    

    // Start is called before the first frame update
    void Awake()
    {

        spriteR = gameObject.GetComponent<SpriteRenderer>();
        Hope = HopeMax;
    }

    public void Damage(int damageCount)
    {
        //todo FindObjectOfType<AudioManager>().Play("Player_Hit");                  //后期加入音效/bgm
        // anim.SetTrigger("Hit");
        Hope -= damageCount;
        Hope = Mathf.Clamp(Hope, 0, HopeMax);
        // DamageTextControler.CreatDamageText(damageCount.ToString(), mainObject.transform);
        //currentHealth();       计算Heart数
        //print(Hope);
    }

    // Update is called once per frame
    void Update()
    {
        Hope = Mathf.Clamp(Hope, 0, HopeMax);
        /*if (Hp <= 0 && dead == false)
        {
            // TODO 帧动画事件淡出+destroy 
            // destroy the object or play the dead animation

            DieStart(mainObject);
            dead = true;
        }*/
        // print(Hope);

        if (60 <Hope & Hope<= 80)
        {
            spriteR.sprite = HopeSprites[0];
        }
        else if (Hope <= 60)
        {
            spriteR.sprite = HopeSprites[1];
        }


    }
}
