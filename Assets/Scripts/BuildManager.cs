using UnityEngine;

public class BuildManager : MonoBehaviour
{
    #region Singleton
    public static BuildManager instance;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("L'instance de [BuildManager] rencontre un problème, elle est déjà initialisé");
            return;
        }
        instance = this;
    }
    #endregion

    public GameObject buildEffect;

    public NodeUI nodeUI;

    [HideInInspector]
    public TurretBlueprint turretToBuild;
    private Node selectedNode;

    public bool canBuild { get { return turretToBuild != null; } }
    public bool hasMoney { get { return PlayerStats.money >= turretToBuild.cost; } }

    public void SelectTurretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;
        DeselectNode();
    }

    public TurretBlueprint getTurretToBuild()
    {
        return turretToBuild;
    }

    public void SelectNode(Node node)
    {
        if(node == selectedNode)
        {
            DeselectNode();
            return;
        }

        selectedNode = node;
        turretToBuild = null;

        nodeUI.SetTarget(node);
    }

    public void DeselectNode()
    {
        selectedNode = null;
        nodeUI.Hide();
    }
}
