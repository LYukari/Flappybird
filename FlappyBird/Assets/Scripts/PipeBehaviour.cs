using System;
using UnityEngine;

public class PipeBehavior : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float initialPos = 1.1f;
    [SerializeField] private float endPos = -0.79f;
    private void Update()
    {
        transform.Translate (Vector2.left * moveSpeed * Time.deltaTime);
        
        if (transform.position.x < endPos)
        {
            transform.position = new Vector3(initialPos, transform.position.y, transform.position.z);
        }
    }
}