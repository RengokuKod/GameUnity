using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject wallPrefab;
    public GameObject coinPrefab;
    public GameObject mobPrefab;
    public GameObject marioPrefab;
    public GameObject fonPrefab; // �������� ���

    public int width = 50;
    public int height = 10;

    private int coinCount = 0;
    private int mobCount = 0;

    void Start()
    {
        GenerateLevel();
    }

    void GenerateLevel()
    {
        int fonCount = 0;
        // ������� ���
        for (int i = 0; i < width; i++)
        {
            Instantiate(wallPrefab, new Vector2(i, 0), Quaternion.identity);
            if (i % 39 == 0)
            {
                GameObject fon = Instantiate(fonPrefab, new Vector3(i, 9,1), Quaternion.identity);
                // ���� fonCount ������� �� 2 ��� �������, �� ������������� ���
                if (fonCount % 2 == 0)
                {
                    fon.GetComponent<SpriteRenderer>().flipX = true;
                }
                fonCount++;

            }
        }

            // ������� ���������
            for (int i = 0; i < width; i += 7) // ����������� ���������� ����� �����������
        {
            int platformWidth = 3;
            int platformHeight = Random.Range(2, height);
            for (int j = 0; j < platformWidth; j++)
            {
                Instantiate(wallPrefab, new Vector2(i + j, platformHeight), Quaternion.identity);
            }

            // ����������� ������ � ������ �� ����������
            if (coinCount < 6)
            {
                Instantiate(coinPrefab, new Vector2(i, platformHeight + 1), Quaternion.identity);
                coinCount++;
            }
            else if (mobCount < 6)
            {
                Instantiate(mobPrefab, new Vector2(i, platformHeight + 1), Quaternion.identity);
                mobCount++;
            }
        }

        // ������� ������ �����
        Vector2 playerPosition = new Vector2(5, 1);
        while (Physics2D.OverlapCircle(playerPosition, 0.5f, LayerMask.GetMask("wall")) != null)
        {
            playerPosition = new Vector2(playerPosition.x + 1, playerPosition.y);
        }
        GameObject player = Instantiate(marioPrefab, playerPosition, Quaternion.identity);
        player.tag = "Player";
        // �������� ��� �������
        player.name = "Player";
    }
}