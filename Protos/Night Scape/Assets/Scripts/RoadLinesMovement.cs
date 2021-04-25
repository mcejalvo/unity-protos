using UnityEngine;

public class RoadLinesMovement : MonoBehaviour
{
    [SerializeField] private float positionToReset = -5f;

    GameConfig gameConfig;

    private void Start()
    {
        gameConfig = FindObjectOfType<GameConfig>();
    }

    private void Update()
    {
        MoveLines();
    }

    private void MoveLines()
    {
        transform.Translate(0,0, gameConfig.carSpeed * Time.deltaTime);

        if (transform.position.z < positionToReset)
        {
             
            Destroy(gameObject);
        }
    }
    
}
