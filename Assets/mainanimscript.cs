using UnityEngine;

public class Mainanimscript : MonoBehaviour
{
    public float moveSpeed = 1;
    public float changeDirectionInterval = 1;
    private Vector2 movement;
    private float timeSinceLastChange;
    

    void Start()
    {
        timeSinceLastChange = changeDirectionInterval;
        
    }

    void Update()
    {
        timeSinceLastChange += Time.deltaTime;

        if (timeSinceLastChange >= changeDirectionInterval)
        {
            movement = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
            timeSinceLastChange = 0f;
        }

        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}