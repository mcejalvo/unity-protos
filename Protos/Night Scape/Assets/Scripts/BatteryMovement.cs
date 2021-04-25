using UnityEngine;

public class BatteryMovement : MonoBehaviour
{
    GameConfig gameConfig;

    private void Start()
    {
        gameConfig = FindObjectOfType<GameConfig>();
    }

    private void Update()
    {
        MoveBattery();
    }

    private void MoveBattery()
    {
        transform.Translate(0, 0, gameConfig.carSpeed * Time.deltaTime);
        if (transform.position.z < -5)
        {
            Destroy(gameObject);
        }
    }
}
