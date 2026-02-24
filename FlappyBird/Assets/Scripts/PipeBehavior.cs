using UnityEngine;

public class PipeBehavior : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;


    private void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime) ;
    }
}
