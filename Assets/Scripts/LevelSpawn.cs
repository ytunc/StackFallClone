using UnityEngine;

public class LevelSpawn : MonoBehaviour
{
    public Material dark;
    public GameObject[] obstaclePrefab;
    public GameObject winPrefrefabs;

    public int level;
    public Vector3 obstacleVector3;
    public Vector3 eulerAnges;
    public int rotateY;

    public int rndCountObstacle;
    public GameObject[] formedObstacle;

    public GameObject UI;

    private void Awake()
    {
        level = PlayerPrefs.GetInt("level");
    }

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    

    [ContextMenu("Spawn")]
    public void Spawn()
    {
        rndCountObstacle = Random.Range(15,45);
        formedObstacle = new GameObject[rndCountObstacle];
        int rndObstacle = Random.Range(0 , obstaclePrefab.Length);

        for (int i = 0; i < rndCountObstacle; i++)
        {
            GameObject clone =  Instantiate(obstaclePrefab[rndObstacle], obstacleVector3,
                Quaternion.Euler(eulerAnges));
            obstacleVector3.y = obstacleVector3.y - 0.5f;
            eulerAnges.y = eulerAnges.y + rotateY;
            formedObstacle[i] = clone;
            clone.name = i.ToString();
            clone.transform.parent = gameObject.transform;


        }
        GameObject winprefab = Instantiate(winPrefrefabs, obstacleVector3, Quaternion.identity);
        winprefab.transform.parent = gameObject.transform;

        UI.GetComponent<UI>().ConfigSlider();
    }

    void Destroyer()
    {
        for (int i = 0; i < formedObstacle.Length; i++)
        {
            Destroy(formedObstacle[i]);
        }

    }


}
