using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndFly : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;
    private SpriteRenderer spriteRenderer;
    // Use this for initialization
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        // offset = target.position - this.transform.position;
    }
    
    // Update is called once per frame
    void Update()
    {
        //float step = 3 * Time.deltaTime;
        //gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, target.position, step);

        // GameObject hp_bar = (GameObject)Instantiate(Resources.Load("Prefab/3(1)"));
        spriteRenderer.maskInteraction = SpriteMaskInteraction.None;

        transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, 10);
       // iTween.MoveTo(gameObject, iTween.Hash("position", target.position, "speed", 50, "easetype", "linear"));
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, target.position, 5);
        transform.parent = target.parent;
        if (gameObject.transform.position == target.transform.position)
        {
            iTween.ScaleTo(gameObject, iTween.Hash("scale", target.localScale, "time", 0.1));
        }
      //  iTween.ScaleTo(gameObject, iTween.Hash("scale", target.localScale, "time", 1));

    }

}
