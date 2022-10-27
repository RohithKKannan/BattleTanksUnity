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

    public void SpawnTank(TankTypes _tankType)
    {
        int index = 0;
        if (_tankType == TankTypes.BlueTank)
            index = 1;
        else if (_tankType == TankTypes.GreenTank)
            index = 0;
        else
            index = 2;
        TankModel tankModel = new TankModel(tanks[index].movementSpeed, tanks[index].rotationSpeed, tanks[index].tankType, tanks[index].color);
        TankController tankController = new TankController(tankModel, tankPrefab);
    }
}
