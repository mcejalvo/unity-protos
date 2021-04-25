using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using TMPro;
using UnityEngine.UI;

public class PlayfabManager : MonoBehaviour
{
    public GameObject rowPrefab;
    public Transform rowsParent;
    public GameObject nameWindow;
    public GameObject leaderboardWindow;
    public InputField nameInput;
    [SerializeField] private int maxNumberRowsLeaderboard = 6;

    // Start is called before the first frame update
    void Start()
    {
        Login();
        
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.F1))
        {
            GetLeaderboard();
        }
        
        if (Input.GetKeyDown(KeyCode.F2))
        {
            SubmitNameButton();
            GetLeaderboard();
        }
    }


    void Login()
    {
        var request = new LoginWithCustomIDRequest
        {
            CustomId = SystemInfo.deviceUniqueIdentifier,
            CreateAccount = true,
            InfoRequestParameters = new GetPlayerCombinedInfoRequestParams
            {
                GetPlayerProfile = true
            }
        };

        
        PlayFabClientAPI.LoginWithCustomID(request, OnSuccess, OnError);
        
        
    }

    void OnSuccess(LoginResult result)
    {
        Debug.Log("Successful login!");
        string name = null;
        if (result.InfoResultPayload.PlayerProfile != null)
        {
            name = result.InfoResultPayload.PlayerProfile.DisplayName;
        }
        
        Debug.Log(name);

        
    }

    static void OnError(PlayFabError error)
    {
        Debug.Log("Error login");
        Debug.Log(error.GenerateErrorReport());
    }

    public static void SendLeaderboard(int score)
    {
        var request = new UpdatePlayerStatisticsRequest
        {
            Statistics = new List<StatisticUpdate>
            {
                new StatisticUpdate
                {
                    StatisticName = "PlatformScore",
                    Value = score
                }
            }
        };
            
        PlayFabClientAPI.UpdatePlayerStatistics(request, OnLeaderboardUpdate, OnError);
    }

    static void OnLeaderboardUpdate(UpdatePlayerStatisticsResult result)
    {
        Debug.Log("Successful leaderboard sent!");
    }

    public void GetLeaderboard()
    {
        var request = new GetLeaderboardRequest
        {
            StatisticName = "PlatformScore",
            StartPosition = 0,
            MaxResultsCount = 10
        };
        PlayFabClientAPI.GetLeaderboard(request, OnLeaderboardGet, OnError);
    }

    public void SubmitNameButton()
    {
        nameWindow.SetActive(true);
        var request = new UpdateUserTitleDisplayNameRequest
        {
            
            DisplayName = nameInput.text,
        };
        
        PlayFabClientAPI.UpdateUserTitleDisplayName(request, OnDisplayNameUpdate, OnError);
        
    }

    private void OnDisplayNameUpdate(UpdateUserTitleDisplayNameResult result)
    {
        leaderboardWindow.SetActive(true);
    }

    // ReSharper disable Unity.PerformanceAnalysis
    private void OnLeaderboardGet(GetLeaderboardResult result)
    {

        foreach (Transform item in rowsParent)
        {
            Destroy(item.gameObject);
        }
        
        int rowCount = 0;
        foreach (var item in result.Leaderboard)
        {
            rowCount++;

            if (rowCount < maxNumberRowsLeaderboard)
            {
                GameObject newGo = Instantiate(rowPrefab, rowsParent);
           
                TextMeshProUGUI[] texts;
                texts = newGo.GetComponentsInChildren<TextMeshProUGUI>();
            
            
                texts[0].text = (item.Position + 1) + "";
                if (item.DisplayName != null)
                {
                    texts[1].text = item.DisplayName;
                }

                else
                {
                    texts[1].text = item.PlayFabId;
                }
            
                texts[2].text = item.StatValue + "";
                
            }
            

        }
    }
}
