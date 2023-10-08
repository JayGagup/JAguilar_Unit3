using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(15, 0, 0);
    private PlayerController playerCtrl;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObs", 2, 2);
        playerCtrl = GameObject.Find("player").GetComponent<PlayerController>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObs()
    {
        if (playerCtrl.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
