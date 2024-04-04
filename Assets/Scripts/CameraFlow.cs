using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player; // ������, �� ������� ������� ������

    void Update()
    {
        // ������� ������ "Player", ���� �� ��� �� ��� ������
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        // ���� ������ "Player" ������, ���������� ������
        if (player != null)
        {
            Vector3 newPosition = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
            transform.position = newPosition;
        }
    }
}