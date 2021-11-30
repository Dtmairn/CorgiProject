using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{

    private Transform playerPosition;
    public float camOffsetPos;

    // Start is called before the first frame update
    void Start()
    {
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        Vector3 camCurrent = transform.position;
        camCurrent.x = playerPosition.position.x;
        camCurrent.y = playerPosition.position.y;
        camCurrent.x += camOffsetPos;
        transform.position = camCurrent;
    }
}
