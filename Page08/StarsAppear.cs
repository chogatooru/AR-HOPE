using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsAppear : MonoBehaviour
{
    public AnimationCurve curve;//放大的曲线
    //public Button But;
    public float value = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        value = 0;
        if (this.gameObject.activeSelf == true)
        {
            
            StartCoroutine(buttonAnimation());
        }
    }
    // Update is called once per frame
    IEnumerator buttonAnimation()
    {
        
        while (true)
        {
            this.transform.localScale = Vector3.one * curve.Evaluate(value += Time.deltaTime * 2);
            yield return null;
            if (value >= 1)
            {
                break;
            }
        }
    }
}
