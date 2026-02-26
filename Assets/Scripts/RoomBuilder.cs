using UnityEngine;

public class RoomBuilder : MonoBehaviour
{
    public GameObject playerPrefab;

    [Header("Wall Prefab")]
    public GameObject wallPrefab;

    [Header("Room Size (in units)")]
    public int width = 10;
    public int height = 8;

    void Start()
    {
        BuildRoom();
        SpawnPlayer();
    }

    void BuildRoom()
    {
        float halfWidth = width / 2f;
        float halfHeight = height / 2f;

        // Top & Bottom walls
        for (int x = -width / 2; x <= width / 2; x++)
        {
            // Top
            Instantiate(wallPrefab, new Vector3(x, halfHeight, 0), Quaternion.identity, transform);

            // Bottom
            Instantiate(wallPrefab, new Vector3(x, -halfHeight, 0), Quaternion.identity, transform);
        }

        // Left & Right walls
        for (int y = -height / 2; y <= height / 2; y++)
        {
            // Left
            Instantiate(wallPrefab, new Vector3(-halfWidth, y, 0), Quaternion.identity, transform);

            // Right
            Instantiate(wallPrefab, new Vector3(halfWidth, y, 0), Quaternion.identity, transform);
        }
    }

    void SpawnPlayer()
    {
        Instantiate(playerPrefab, Vector3.zero, Quaternion.identity);
    }
}