using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player; // Объект, за которым следует камера

    void Update()
    {
        // Находим объект "Player", если он еще не был найден
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        // Если объект "Player" найден, перемещаем камеру
        if (player != null)
        {
            Vector3 newPosition = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
            transform.position = newPosition;
        }
    }
}