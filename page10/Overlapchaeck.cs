using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overlapchaeck : MonoBehaviour
{
    //判定覆盖范围
    Collider2D col2D;
    Collider2D[] result;
    // Start is called before the first frame update
    public float count;
    public float awakecount;
    public float graynum;

    void Awake()
    {
        col2D = GetComponent<Collider2D>();
        result = new Collider2D[10];
      awakecount = col2D.OverlapCollider(new ContactFilter2D(), result);

    }


    // Update is called once per frame
    void Update()
    {
       graynum = count / awakecount;
        count = col2D.OverlapCollider(new ContactFilter2D(), result);
        print(count);
    }
}
