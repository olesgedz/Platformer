using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Transform farBackground, midBackground;
    private Vector2 lastPos;
    [SerializeField] float minHieght, maxHieght;
    void Start()
    {
        lastPos = transform.position;
    }

    void Update()
    {
        transform.position = new Vector3(target.position.x, Mathf.Clamp(target.position.y, minHieght, maxHieght),
            transform.position.z);
        Vector2 amountToMove =new Vector2(transform.position.x - lastPos.x, transform.position.y - lastPos.y);
        farBackground.position += new Vector3(amountToMove.x, amountToMove.y, 0f);
        midBackground.position += new Vector3(amountToMove.x, amountToMove.y, 0f) * 0.5f;
        lastPos = transform.position;
    }
}
