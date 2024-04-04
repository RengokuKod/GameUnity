using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobMove : MonoBehaviour
{
    // Start is called before the first frame update
    
        public AnimationCurve movementCurve;
    public float speed = 2f;
    public float length = 2f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // PingPong ����� ���������� ��������, ������� ���������� ����-���� ����� 0 � length
        float movement = Mathf.PingPong(Time.time * speed, length);
        transform.position = startPosition + new Vector3(movement, 0, 0);
    }
}
