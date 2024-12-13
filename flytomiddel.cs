using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flytomiddel : MonoBehaviour
{
    public GameObject page;
    public Transform target;
    public Transform targetfire;
    SpriteRenderer spriteRenderer;
    public Sprite sprite2;
    public GameObject puzzle;
    public bool isfinish = false;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (page.activeSelf)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 225, 255);
            spriteRenderer.maskInteraction = SpriteMaskInteraction.None;
            spriteRenderer.sortingOrder = 10;
            // gameObject.transform.localScale = target.localScale;
            // iTween.MoveTo(gameObject, iTween.Hash("position", target.position, "speed", 50, "easetype", "linear"));
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, target.position, 1);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, 10);
            transform.parent = target.parent;
            if (gameObject.transform.position == target.transform.position)
            {
                iTween.ScaleTo(gameObject, iTween.Hash("scale", target.localScale, "time", 1));
                if(gameObject.transform.localScale== target.localScale)
                {
                    puzzle.SetActive(true);
                }
               
            }
            if (isfinish)
            {
                spriteRenderer.sprite = sprite2;
                gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, targetfire.position, 1);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, targetfire.rotation, 1);


                if (gameObject.transform.position == targetfire.transform.position)
                {
                   // sldie.SetActive(true);
                    transform.parent = targetfire.parent;
                    iTween.ScaleTo(gameObject, iTween.Hash("scale", targetfire.localScale, "time", 1));

                }

            }
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 225, 0);
            puzzle.SetActive(false);
        }

    }
}
