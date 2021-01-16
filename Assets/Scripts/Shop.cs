﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseStandardTurret() {
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);        
    }

    public void AnotherStandardTurret()
    {
        Debug.Log("Annother Turret");
        buildManager.SetTurretToBuild(buildManager.anotherTurretPrefab);
    }
}
