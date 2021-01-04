using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float panSpeed = 30f;

    public float scrollSpeed = 5f;

    public float minY = 20f;
    public float maxY = 95f;

    private Vector3 startPosOfCam = new Vector3(38.6f, 78.4f, -21.6f);
    private Vector3 returnBackPosOfCam = new Vector3(38.6f, 78.4f, -21.6f);

    void Update()
    {
        if(GameManager.gameIsOver)
        {
            this.enabled = false;
            return;
        }

        //Avant
        if(Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);
        }
        //Arrière
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
        }


        //Gauche
        if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
        }
        //Droite
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
        }

        //[CamOrigin]
        //Return back to origin camera position
        if (Input.GetKeyDown(KeyCode.C))
        {
            returnBackPosOfCam = transform.position;
            transform.position = startPosOfCam;
        }
        
        //Return back to the last save camera position when [CamOrigin] is used (default = origin position)
        if(Input.GetKeyDown(KeyCode.M))
        {
            transform.position = returnBackPosOfCam;
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");

        Vector3 pos = transform.position;

        pos.y -= scroll * 800 * scrollSpeed * Time.deltaTime;

        pos.y = Mathf.Clamp(pos.y, minY, maxY);

        transform.position = pos;
    }
}
