using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    private GameObject turreToBuild;
    public GameObject standardTurretPrefab;

    public static BuildManager instance;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("More than one BuildManager in scene");
        }
        instance = this;
    }

    private void Start()
    {
        turreToBuild = standardTurretPrefab;
    }

    public GameObject GetTurretToBuild ()
    {
        return turreToBuild;
    }
}
