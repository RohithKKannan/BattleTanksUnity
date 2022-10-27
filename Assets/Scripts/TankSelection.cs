using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    public TankSpawner tankSpawner;
    public void GreenTankSelected()
    {
        tankSpawner.SpawnTank(TankTypes.GreenTank);
        gameObject.SetActive(false);
    }
    public void RedTankSelected()
    {
        tankSpawner.SpawnTank(TankTypes.RedTank);
        gameObject.SetActive(false);
    }
    public void BlueTankSelected()
    {
        tankSpawner.SpawnTank(TankTypes.BlueTank);
        gameObject.SetActive(false);
    }
}
