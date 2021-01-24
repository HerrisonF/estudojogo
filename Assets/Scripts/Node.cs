using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 positionOffSet;

    [Header("Optional")]
    public GameObject turret;

    BuildManager buildManager;

    private Renderer rend;
    private Color startColor;
    private void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        buildManager = BuildManager.instance;
    }

    public Vector3 getBuildPosition()
    {
        return transform.position + positionOffSet;
    }

    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (!buildManager.CanBuild)
            return;
        
        if(turret != null)
        {
            Debug.Log("Can't build there ! - TODO: display on screen.");
            return;
        }

        buildManager.BuildTurretOn(this);
    }



    private void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (buildManager.CanBuild)
            return;

        rend.material.color = hoverColor; 
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
