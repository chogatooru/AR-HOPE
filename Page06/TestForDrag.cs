using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TestForDrag : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public GameObject target;
    public void OnDrag(PointerEventData eventData)
    {
        //将鼠标的位置坐标进行钳制，然后加上位置差再赋值给图片position
        transform.position = Input.mousePosition;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        transform.localPosition = Vector3.zero;
       /* Collider2D[] cols = Physics2D.OverlapCircleAll(gameObject.transform.position, 1);

        foreach(Collider2D col in cols)
        {
            if(col == target)
            {
                gameObject.transform.position = target.gameObject.transform.position;
            }
           else
            {
                transform.localPosition = Vector3.zero;
            }
        }*/
    }

    void OnTriggerEnter2D(Collider2D collider)
    {

            print("2432");
        gameObject.SetActive(false);
  
    }


}
