using UnityEngine;

public class ParticeMove : MonoBehaviour
{
    public AnimationCurve movementCurve;
    public float speed = 2f;
    public float length = 100f;

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