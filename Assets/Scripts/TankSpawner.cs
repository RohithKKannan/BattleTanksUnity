using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public TankView tankPrefab;
    // Start is called before the first frame update
    void Start()
    {
        SpawnTank();
    }

    void SpawnTank()
    {
        TankModel tankModel = new TankModel(30f, 60f);
        TankController tankController = new TankController(tankModel, tankPrefab);
    }
}
