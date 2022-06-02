using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform lookAt;
    public float boundX = 0.0001f;
    public float boundY = 0.0001f;

    private void LateUpdate()
    {
        Vector3 delta = Vector3.zero;
        //inside X axis bound
        float deltaX = lookAt.position.x - transform.position.x; //bakýlan konum - bulunan konumu
        if(deltaX > boundX || deltaX < -boundX)
        {
            delta.x = deltaX - boundX;
        }
        else
        {
            delta.x = deltaX + boundX;
        }
        //inside Y axis bound
        float deltaY = lookAt.position.y - transform.position.y; //bakýlan konum - bulunan konumu
        if (deltaY > boundY || deltaY < -boundY)
        {
            delta.y = deltaY - boundY;
        }
        else
        {
            delta.y = deltaY + boundY;
        }
        //camera transform movement
        transform.position += new Vector3(delta.x, delta.y, 0);
    }
}
