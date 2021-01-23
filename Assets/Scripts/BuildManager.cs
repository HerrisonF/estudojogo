using UnityEngine;

public class BuildManager : MonoBehaviour
{
    private GameObject turreToBuild;
    public GameObject standardTurretPrefab;
    public GameObject missileLauncherPrefab;

    public static BuildManager instance;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("More than one BuildManager in scene");
        }
        instance = this;
    }

    public GameObject GetTurretToBuild ()
    {
        return turreToBuild;
    }

    public void SetTurretToBuild (GameObject turret)
    {
        turreToBuild = turret;
    }
}
