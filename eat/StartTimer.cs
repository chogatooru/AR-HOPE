using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTimer : MonoBehaviour
{
    public int count_down = 3;
    public GameObject Awake1;
    public GameObject Awake2;
    public GameObject Awake3;
    public GameObject Awake4;
    // Start is called before the first frame update
    void Start()
    {

        GetComponent<UnityEngine.UI.Text>().text = "" + count_down;

        InvokeRepeating("Time_count", 2.0f, 1.0F);

    }

    void Time_count()

    {

        if (count_down > 0)
        {

            count_down--;

            GetComponent<UnityEngine.UI.Text>().text = "" + count_down;

        }
        else if(count_down==0)
        {
            count_down--;
            GetComponent<UnityEngine.UI.Text>().text = "GO!" ;
        }
        else if (count_down == -1)
        {
            CancelInvoke();
            Awake1.SetActive(true);
            Awake2.SetActive(true);
            Awake3.SetActive(true);
            Awake4.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
