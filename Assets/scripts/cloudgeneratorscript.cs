using UnityEngine;

public class cloudgeneratorscript : MonoBehaviour
{
    [SerializeField]
    GameObject[] cloud;

    [SerializeField]
    GameObject[] size; 

    [SerializeField]
    float spawnInterval;

    [SerializeField]
    GameObject endPoint;

    Vector3 startPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
