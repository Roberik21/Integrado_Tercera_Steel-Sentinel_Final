using System.Collections;
using System.Collections;
using UnityEngine;

public class SpawnEnemy_3 : MonoBehaviour
{
    private static SpawnEnemy_3 instance;

    public static SpawnEnemy_3 Instance
    {
        get { return instance; }
    }

    public GameObject TheEnemy_1;
    public GameObject TheEnemy_2;
    public GameObject TheEnemy_3;
    public int enemyCounts;
    [SerializeField] int maxEnemies;
    [SerializeField] bool canSpawn;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        canSpawn = true;
        InvokeRepeating(nameof(SpawnEnemies), 1f, 1f); // Llama a SpawnEnemies cada segundo
    }

    void SpawnEnemies()
    {
        if (enemyCounts >= maxEnemies || !canSpawn) return;

        int randomZone = Random.Range(1, 4);
        switch (randomZone)
        {
            case 1:
                Spawn_1();
                break;
            case 2:
                Spawn_2();
                break;
            case 3:
                Spawn_3();
                break;
        }
    }

    void Spawn_1()
    {
        if (canSpawn)
        {
            canSpawn = false;
            int xPos = Random.Range(-30, -26);
            int zPos = Random.Range(-6, 10);
            int nEnemy = Random.Range(1, 4);
            Debug.Log(nEnemy);
            InstantiateEnemy(nEnemy, xPos, zPos);
            enemyCounts += 1;
            Invoke(nameof(ResetSpawn), 1f);
        }
    }

    void Spawn_2()
    {
        if (canSpawn)
        {
            canSpawn = false;
            int xPos = Random.Range(-30, -26);
            int zPos = Random.Range(-2, 6);
            int nEnemy = Random.Range(1, 4);
            Debug.Log(nEnemy);
            InstantiateEnemy(nEnemy, xPos, zPos);
            enemyCounts += 1;
            Invoke(nameof(ResetSpawn), 1f);
        }
    }

    void Spawn_3()
    {
        if (canSpawn)
        {
            canSpawn = false;
            int xPos = Random.Range(-6, 10);
            int zPos = Random.Range(34, 42);
            int nEnemy = Random.Range(1, 4);
            Debug.Log(nEnemy);
            InstantiateEnemy(nEnemy, xPos, zPos);
            enemyCounts += 1;
            Invoke(nameof(ResetSpawn), 1f);
        }
    }

    void InstantiateEnemy(int nEnemy, int xPos, int zPos)
    {
        GameObject enemy = null;
        switch (nEnemy)
        {
            case 1:
                enemy = TheEnemy_1;
                break;
            case 2:
                enemy = TheEnemy_2;
                break;
            case 3:
                enemy = TheEnemy_3;
                break;
        }
        Instantiate(enemy, new Vector3(xPos, 0.75f, zPos), Quaternion.identity);
    }

    void ResetSpawn()
    {
        canSpawn = true;
    }
}

