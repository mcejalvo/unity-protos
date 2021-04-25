using System;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	private float batteryTimer;
	[SerializeField] private float batteryTimerThreshold = 5.0f;
	[SerializeField] private GameObject batteryPrefab;
	[SerializeField] private GameObject[] obstaclesPrefabList;
	private Vector3 batterySpawnPosition;
	[SerializeField] int batterySpawnDistance = 100;
	[SerializeField] private GameObject EndText;
	private Vector3 LinesPosition;
	[SerializeField] private GameObject roadLinesPrefab;
	private float roadTimer;
	[SerializeField] private float roadDistanceThreshold = 0.5f;
	public float traveledDistance = 0f;
	private float timer = 0f;
	GameConfig gameConfig;
	[SerializeField] private GameObject distanceStatusMonitor;
	private Text distanceMonitorText;
	private Vector3 linesSpawnPosition;
	private float initialLineDistance = 58f;
	private ManageCar manageCar;
	[SerializeField] private GameObject leaderboardCanvas;
	[SerializeField] private GameObject playfabManagerObject;
	private PlayfabManager playfabManager;
	public GameObject nameWindow;
	public GameObject leaderboardWindow;
	private int count;

	private void Start()
	{
		count = 0;
		gameConfig = FindObjectOfType<GameConfig>();
		manageCar = FindObjectOfType<ManageCar>();
		playfabManager = FindObjectOfType<PlayfabManager>();
		

		distanceMonitorText = distanceStatusMonitor.GetComponent<Text>();
		// PlayerPrefs <<- Guardar configuración, stats, info en el dispositivo.
		createInitialLines();
		
	}

	private void Update()
	{
		if (!manageCar.endGame)
		{
			createCentralLines();
			createBatteries();
			createObstacles();
			UpdateTraveledDistance();

		}

		else
		{
			count++;
			if (count == 1)
			{
				playfabManager.GetLeaderboard();
				ActiveLeaderboard();
				playfabManager.GetLeaderboard();
			}

		}

		restartGame();
		
	}

	private void ActiveLeaderboard()
	{
		
		nameWindow.SetActive(true);
		leaderboardWindow.SetActive(true);
		
	}

	private void UpdateTraveledDistance()
	{
		if (!manageCar.endGame)
		{
			timer += Time.deltaTime;
			traveledDistance = -gameConfig.carSpeed * timer;
			distanceMonitorText.text = (0.5 * traveledDistance).ToString("0") + " m";
			
		}
		
	}

	void createBatteries()
	{
		batteryTimer += Time.deltaTime;

		if (batteryTimer > batteryTimerThreshold)
		{
			batterySpawnPosition = new Vector3(Random.Range(-4, 4), 0, batterySpawnDistance);
			Instantiate(batteryPrefab, batterySpawnPosition, Quaternion.identity);
			batteryTimer = 0.0f;
		}
	}

	void createInitialLines()
	{
		for (int i = 0; i < 8; i++)
		{
			LinesPosition = new Vector3(0, 0, 2 + i * 8);
			Instantiate(roadLinesPrefab, LinesPosition, Quaternion.identity);
		}
	}

	void createObstacles()
	{
		batteryTimer += Time.deltaTime;

		if (batteryTimer > batteryTimerThreshold)
		{
			batterySpawnPosition = new Vector3(Random.Range(-4, 4), 0, batterySpawnDistance);

			var prefabRandomIndexToSpawn = Random.Range(0, obstaclesPrefabList.Length);
			Instantiate(obstaclesPrefabList[prefabRandomIndexToSpawn], batterySpawnPosition, Quaternion.identity);
			batteryTimer = 0.0f;
		}
	}

	void createCentralLines()
	{
		roadTimer += Time.deltaTime;
		if (roadTimer > roadDistanceThreshold)
		{
			linesSpawnPosition = new Vector3(0, 0, initialLineDistance);
			Instantiate(roadLinesPrefab, linesSpawnPosition, Quaternion.identity);
			roadTimer = 0f;
		}
	}

	void restartGame()
	{
		if (Input.GetKey(KeyCode.RightControl))
		{
			SceneManager.LoadScene("Endless");
		}
	}
	
	
	

}