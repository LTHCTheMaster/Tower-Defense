using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint standardTurret;
    public TurretBlueprint missileLauncherTurret;
    public TurretBlueprint laserBeamerTurret;

    public TurretBlueprint teslaSecretTower;
    private int teslaKeyStrucGet = 0;

    private BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
        teslaKeyStrucGet = 0;
    }

    public void SelectStandardTurret()
    {
        buildManager.SelectTurretToBuild(standardTurret);
        teslaKeyStrucGet = 0;
    }

    public void SelectMissileLauncher()
    {
        buildManager.SelectTurretToBuild(missileLauncherTurret);
        teslaKeyStrucGet = 0;
    }

    public void SelectLaserBeamer()
    {
        buildManager.SelectTurretToBuild(laserBeamerTurret);
        teslaKeyStrucGet = 0;
    }

    public void SelectTeslaSecretTower()
    {
        buildManager.SelectTurretToBuild(teslaSecretTower);
    }

    public static bool IsTesla(TurretBlueprint toTest)
    {
        if(toTest.name == "tesla")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.G) && teslaKeyStrucGet == 0)
        {
            teslaKeyStrucGet = 1;
        }
        if (Input.GetKeyDown(KeyCode.H) && teslaKeyStrucGet == 1)
        {
            teslaKeyStrucGet = 2;
        }
        if (Input.GetKeyDown(KeyCode.J) && teslaKeyStrucGet == 2)
        {
            SelectTeslaSecretTower();
            teslaKeyStrucGet = 0;
        }
    }
}
