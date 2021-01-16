using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 positionOffSet;

    private GameObject turret;

    private Renderer rend;
    private Color startColor;
    private void Start()
    {
        rend = GetComponent<Renderer>();
    }

    private void OnMouseDown()
    {
        if(turret != null)
        {
            Debug.Log("Can't build there ! - TODO: display on screen.");
            return;
        }

        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = Instantiate(turretToBuild, transform.position + positionOffSet, transform.rotation);
    }

    private void OnMouseEnter()
    {
        startColor = rend.material.color;
        rend.material.color = hoverColor; 
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
