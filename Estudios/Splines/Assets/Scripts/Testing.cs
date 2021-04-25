using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    private float interpolateAmount;
    [SerializeField] private Transform pointA;
    [SerializeField] private Transform pointB;
    [SerializeField] private Transform pointC;
    [SerializeField] private Transform pointD;
    [SerializeField] private Transform pointAB;
    [SerializeField] private Transform pointBC;
    [SerializeField] private Transform pointCD;
    [SerializeField] private Transform pointAB_BC;
    [SerializeField] private Transform pointBC_CD;
    [SerializeField] private Transform pointABCD;

    // Update is called once per frame
    void Update()
    {
        interpolateAmount = (interpolateAmount + Time.deltaTime) % 1f;

        pointAB.position = Vector3.Lerp(pointA.position, pointB.position, interpolateAmount);
        pointBC.position = Vector3.Lerp(pointB.position, pointC.position, interpolateAmount);
        pointCD.position = Vector3.Lerp(pointC.position, pointD.position, interpolateAmount);

        pointAB_BC.position = Vector3.Lerp(pointAB.position, pointBC.position, interpolateAmount);
        pointBC_CD.position = Vector3.Lerp(pointBC.position, pointCD.position, interpolateAmount);

        pointABCD.position = Vector3.Lerp(pointAB_BC.position, pointBC_CD.position, interpolateAmount);
    }

    
}
