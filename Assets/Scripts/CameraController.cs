using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Transform farBackground, midBackground;
    private float lastXPos;

    void Start()
    {
        lastXPos = transform.position.x;
    }

    void Update()
    {
        transform.position = new Vector3(target.position.x, transform.position.y,
           transform.position.z);

        float amountToMoveX = transform.position.x - lastXPos;
        farBackground.position += new Vector3(amountToMoveX, 0f, 0f);
        midBackground.position += new Vector3(amountToMoveX * 0.5f, 0f, 0f);
        lastXPos = transform.position.x;
    }
}
