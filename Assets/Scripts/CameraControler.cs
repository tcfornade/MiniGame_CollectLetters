using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
public class CameraController : MonoBehaviour 
{ 

    private Vector3 offset; 
    public GameObject Player_user; 

    public float camRotationSpeed = 15.0f;
    // Start is called before the first frame update 
    void Start() 
    { 
         offset = transform.position; 
    } 
       
    private void LateUpdate() 
    { 
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X")* camRotationSpeed, Vector3.up) * offset;
        transform.position = Player_user.transform.position + offset;
        transform.LookAt(Player_user.transform.position);
    } 
}