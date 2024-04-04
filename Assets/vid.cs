using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MazeGenerator : MonoBehaviour
{
    public int width, height;
    public float scale = 20f;
    private float[,] maze;

    void Start()
    {
        maze = new float[width, height];
        GenerateMaze();
    }

    void GenerateMaze()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                float xCoord = (float)x / width * scale;
                float yCoord = (float)y / height * scale;
                maze[x, y] = Mathf.PerlinNoise(xCoord, yCoord);
            }
        }
    }

    void OnDrawGizmos()
    {
        if (maze != null)
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Gizmos.color = new Color(maze[x, y], maze[x, y], maze[x, y]);
                    Vector3 pos = new Vector3(-width / 2 + x + .5f, -height / 2 + y + .5f, 0);
                    Gizmos.DrawCube(pos, Vector3.one);
                }
            }
        }
    }
}