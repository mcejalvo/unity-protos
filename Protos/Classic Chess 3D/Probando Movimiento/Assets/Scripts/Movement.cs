using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Movement : MonoBehaviour
{
    [Header("Parámetros")] 
    [SerializeField] private float generalSpeed = 0.1f;
    [SerializeField] private float initialVelocityHorizontal = 1;
    [SerializeField] private float initialVelocityVertical = 1;
    [SerializeField] private float acceleration = -0.5f;
    [SerializeField] private GameObject prefabPajaro;
    [SerializeField] private Vector2 posicionPajaro = new Vector2(-6, 0);
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }
    

    // Update is called once per frame
    void Update()
    {
        float t = Time.time;
        float deltaX = generalSpeed * initialVelocityHorizontal * t;
        float deltaY = generalSpeed * initialVelocityVertical * t + 0.5f * acceleration * (Mathf.Pow(t,2));
        transform.Translate(new Vector2(deltaX, deltaY));
        
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(GameObject.Find("Pájaro"));
            if (GameObject.Find("Pájaro") == null)
            {
                
                var newPrefab = Instantiate(prefabPajaro, posicionPajaro, Quaternion.identity);
                newPrefab.name = ("Pájaro");
            }
            
        }
        
    }
    
}
