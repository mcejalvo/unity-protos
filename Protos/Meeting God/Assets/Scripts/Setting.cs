using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Setting : MonoBehaviour
{
    [SerializeField] GameObject platformPrefab;    
    [SerializeField] Camera camObject;
    [SerializeField] GameObject player;

    [Header("Settings Parameters")]
    [SerializeField] int platformVerticalPosition;
    [SerializeField] int numberPlatforms = 3;
    

    InputMaster sceneControls;
    Camera cam;
    float platformsInitialPoint;
    GameObject platformInstantiated;
    float platformPrefabInitialScale;
    int originalScreenWidth;
    bool aspectRatioChange;
    float playerInitialScale;



    void Awake()
    {
        originalScreenWidth = Screen.width;
        cam = camObject.GetComponent<Camera>();
        sceneControls = new InputMaster();
        sceneControls.Setting.PlatformSpawn.performed += ctx => CreatePlatforms();     

        // Print mouse position   
        sceneControls.Setting.ScreenPosition.performed += ctx => printPosition();
        

    } 

    void Start()
    {
        playerInitialScale = player.transform.localScale.x;
    }

    void Update()
    {
        DetectAspectRatio();

        if (aspectRatioChange)
        {
            PlayerScale();            
            aspectRatioChange = false;
        }
    }

    void PlayerScale()
    {
        player.transform.localScale = new Vector3(playerInitialScale * Screen.width / 1920f, playerInitialScale * Screen.width / 1920f, 1);
    }


    void DetectAspectRatio()
    {
        if (Screen.width != originalScreenWidth)
        {
            aspectRatioChange = true;
            originalScreenWidth = Screen.width;
        }
    }

    void CreatePlatforms()
    {
        platformsInitialPoint = Screen.width / 4;
        platformVerticalPosition = Screen.height / 3; 
        Vector3 platformPosition = new Vector3 (platformsInitialPoint, platformVerticalPosition, 1);
        
        for (int i = 0; i < numberPlatforms; i++)
        {
            platformInstantiated = Instantiate(platformPrefab, cam.ScreenToWorldPoint(platformPosition), Quaternion.identity);
            platformPrefabInitialScale = platformInstantiated.transform.localScale.x;
            platformInstantiated.transform.localScale = new Vector3(platformPrefabInitialScale * Screen.width / 1920f, 0.3f, 1);
            platformPosition.x += platformsInitialPoint;
        }
    }

    void printPosition()
    {
        Vector2 mousePosition = Mouse.current.position.ReadValue();
        Debug.Log($"{Screen.width} x {Screen.height}");
        Debug.Log(mousePosition);

        // Debug.Log(Camera.main.ScreenToWorldPoint(new Vector2(position.x, position.y)));
        // Debug.Log(new Vector2(position.x, position.y));

    }

    #region - Enable/disable -
    private void OnEnable() 
    {
        sceneControls.Enable();
    }

    private void OnDisable()
    {
        sceneControls.Disable();
    }

    #endregion

    
}

