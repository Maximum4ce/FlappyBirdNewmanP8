using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollumPool : MonoBehaviour
{
    public float columnMax = 3.5f;
    public float columnMin = -1f;
    public float spawnRate = 4f;
    public int columnPoolSize = 5;
    private GameObject[] columns;
    public GameObject columnPrefab;
    private Vector2 objectPoolPosition = new Vector2 (-15f, -25f);
    private float timeSinceLastSpawned;
    private float spawnXPosition = 10f;
    private int currentColumn = 0;
    // Start is called before the first frame update
    void Start()
    {
        columns= new GameObject[columnPoolSize];
        for (int i = 0; i < columnPoolSize; i++)
        {
            columns[i] = (GameObject)Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;
        if(GameControl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0;
            float spawnYposition = Random.Range(columnMin, columnMax);
            columns[currentColumn].transform.position = new Vector2 (spawnXPosition, spawnYposition);
            currentColumn++;
            if(currentColumn >= columnPoolSize)
            {
                currentColumn = 0;
            }
        }
    }
}
