using System;
using UnityEngine;
using UnityEngine.UI;

public class ManageCar : MonoBehaviour
{
    [SerializeField] private float BatteryMaxCapacity = 5.0f;  // in seconds until empty
    [SerializeField] private float BatteryRefillAmount = 2.0f; // seconds of refill
    [SerializeField] private float lateralSpeed = 2.0f;
    [SerializeField] private GameObject batteryStatusMonitor;
    [SerializeField] private GameObject EndText;
    [SerializeField] private GameObject ShortRight;
    [SerializeField] private GameObject ShortLeft;
    [SerializeField] private GameObject LongLeft;
    [SerializeField] private GameObject LongRight;
    [SerializeField] private float batteryDecrease = 0.001f ;
    public bool endGame;
    public float batteryStatus;
    private Text batteryMonitorText;
    private GameConfig gameConfig;
    private GameManager gameManager;
    [SerializeField] private float breakRatio;
    [SerializeField] private GameObject LowBattery;
    public GameObject nameWindow;

    private void Start()
    {
        gameConfig = FindObjectOfType<GameConfig>();
        gameManager = FindObjectOfType<GameManager>();
        batteryMonitorText = batteryStatusMonitor.GetComponent<Text>();
        batteryStatus = BatteryMaxCapacity;
    }
    
    private void Update()
    {
        UpdateCarController();
        UpdateCarStatus();
        UpdateEndCondition();
        CheckLongLights();

        if (GetBatteryPercentage() < 0.5 & GetBatteryPercentage() > 0 & !endGame)
        {
            LowBattery.SetActive(true);
        }

        else
        {
            LowBattery.SetActive(false);
        }
        
        
    }

    private void CheckLongLights()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ShortLeft.SetActive(false);
            ShortRight.SetActive(false);
            LongLeft.SetActive(true);
            LongRight.SetActive(true);
            batteryStatus -= batteryDecrease * Time.deltaTime;
        }
        
        if (Input.GetKeyUp(KeyCode.Space))
        {
            ShortLeft.SetActive(true);
            ShortRight.SetActive(true);
            LongLeft.SetActive(false);
            LongRight.SetActive(false);
            
        }
        
        
    }
    

    private void UpdateCarController()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // TODO arreglar esta ponzoña
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3 (-lateralSpeed * Time.deltaTime, 0, 0));
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3 (lateralSpeed * Time.deltaTime, 0, 0));

        }
    }

    private void UpdateCarStatus()
    {
        if (batteryStatus > 0f)
        {
            batteryStatus = Mathf.Clamp(batteryStatus - Time.deltaTime, 0f, BatteryMaxCapacity);
        }

        else
        {
            gameConfig.carSpeed = Mathf.Clamp(gameConfig.carSpeed - breakRatio * breakRatio, -10f, 0);
        }

        batteryMonitorText.text = batteryStatus.ToString("0.0");
    }

    private void UpdateEndCondition()
    {
        if (batteryStatus <= 0f)
        {
            EndText.SetActive(true);
            nameWindow.SetActive(true);
            
            endGame = true;
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.CompareTag("battery"))
        {
            batteryStatus = Mathf.Clamp(batteryStatus + BatteryRefillAmount, 0, BatteryMaxCapacity);
            Destroy(collision.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("obstacles"))
        {
            endGame = true; 
            Destroy(gameObject);
            Destroy(LowBattery);
            EndText.SetActive(true);
            PlayfabManager.SendLeaderboard((int)Math.Round(gameManager.traveledDistance/2f));
        }
    }

    public float GetBatteryPercentage()
    {
        return batteryStatus / BatteryMaxCapacity;
    }
}


