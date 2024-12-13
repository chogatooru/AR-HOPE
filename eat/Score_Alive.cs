using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Alive : MonoBehaviour
{
    public static int score = 0;
    //Text score_text;
    // Start is called before the first frame update
    void Awake()
    {
        score = 0;
;
    }
    
    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = score.ToString();
    }
}
