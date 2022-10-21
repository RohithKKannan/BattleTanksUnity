using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public float movementSpeed;
        public float rotationSpeed;
        public TankTypes tankType;
        public Material color;
    }
    public List<Tank> tanks;
    public TankView tankPrefab;
    // Start is called before the first frame update
    void Start()
    {
        SpawnTank();
    }

    void SpawnTank()
    {
        TankModel tankModel = new TankModel(tanks[0].movementSpeed, tanks[0].rotationSpeed, tanks[0].tankType, tanks[0].color);
        TankController tankController = new TankController(tankModel, tankPrefab);
    }
}
