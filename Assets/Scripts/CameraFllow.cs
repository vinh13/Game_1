using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFllow : MonoBehaviour
{
    private Transform player;
    private Vector3 temPos;
    private float maxPos = 50f;
    private float minPos = -50f;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!player) return; 

        temPos = transform.position;
        temPos.x = player.position.x;

        if(temPos.x >= maxPos)
        {
            temPos.x = maxPos;

        } else if(temPos.x <= minPos)
        {
            temPos.x = minPos;
        }

        transform.position = temPos;
    }
}
