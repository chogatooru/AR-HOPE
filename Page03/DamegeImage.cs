using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamegeImage : MonoBehaviour
{

    public Image damageImage;
    public float flashSpeed = 5f;
    public Color flashColour = new Color(1f, 0f, 0f, 1f);
    public bool damaged = false;
    public float timer = 1f;

    public int damagecount = 0;

    public bool damagebiggerthan3 = false;

    private AudioSource _audioSource;
    AudioClip audioClip;

    public GameObject otherojb;
    public SpriteRenderer otherspr;
    // Start is called before the first frame update
    void Start()
    {
        //添加 Audio Source 组件
        _audioSource = this.gameObject.AddComponent<AudioSource>();

        //加载 Audio Clip 对象
        audioClip = Resources.Load<AudioClip>("aaaa");
    }
    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "damage")
        {
            otherojb = collider.gameObject;
            otherspr = otherojb.GetComponent<SpriteRenderer>();
            damaged = true;

        }
    }

    void OnCollisionExit2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "damage")
        {
            
            damaged = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (damaged )
        {
            _audioSource.clip = audioClip;
            _audioSource.Play();
            // ... set the colour of the damageImage to the flash colour.
            damagecount++;
            damageImage.color = flashColour;

            if (otherojb != null)
            {
                otherspr.color = flashColour;
            }
            


        }
        // Otherwise...
        else
        {

            // ... transition the colour back to clear.
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
            if (otherojb != null)
            {

                Destroy(otherojb, 1f);
            }

        }
        
      
        damaged = false;


        if(damagecount >=3)
        {
            damagebiggerthan3 = true;
        }
    }
}