using UnityEngine;

public class BuildManager : MonoBehaviour
{
    private TurretBlueprint turreToBuild;

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

    public bool CanBuild { get { return turreToBuild != null; } }

    public void BuildTurretOn (Node node)
    {
        if(PlayerStats.Money < turreToBuild.cost)
        {
            Debug.Log("Not enough money to build that  !");
            return;
        }

        PlayerStats.Money -= turreToBuild.cost;

        GameObject turret = Instantiate(turreToBuild.prefab, node.getBuildPosition(), Quaternion.identity);
        node.turret = turret;

        Debug.Log(PlayerStats.Money);
    }
    public void SelectTurretToBuild (TurretBlueprint turret)
    {
        turreToBuild = turret;
    }

}
