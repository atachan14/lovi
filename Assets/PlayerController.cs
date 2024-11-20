using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 4f;


    private Rigidbody2D rb;
    private Vector3 nextPos;
    private Vector3 direction;
    private bool isMoving = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (isMoving) MoveToNextPos();
    }
    public void ClickMove(Vector3 worldPosition)
    {
        nextPos = worldPosition;
        isMoving = true;
    }

    void MoveToNextPos()
    {
        Vector3 direction = (nextPos - transform.position).normalized;
        float step = speed * Time.fixedDeltaTime;

        rb.MovePosition(transform.position + direction * step);

        if (transform.position == nextPos) isMoving = false;

    }
}
