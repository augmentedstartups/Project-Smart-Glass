using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePerspective : MonoBehaviour
{
    public float calibration = 12.4f;
    public float calibration_y = 12.4f;
    public GameObject FaceCube;
    public Vector3 Zero_Rotation_Position; // Set initial detection as Start rotation
    public Vector3 Current_Rotation_Position; // Continuous detection position
    public Vector3 Diff_Rotation_Position; // Continuous detection position
    // Start is called before the first frame update
    void Awake()
    {
        Zero_Rotation_Position = FaceCube.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Current_Rotation_Position = FaceCube.transform.position;
        Diff_Rotation_Position = Current_Rotation_Position - Zero_Rotation_Position;
        this.transform.position = new Vector3((Diff_Rotation_Position.x / 1), (Diff_Rotation_Position.y / 1)+91, -689); 
      
        this.transform.eulerAngles = new Vector3((Diff_Rotation_Position.y / calibration_y), -(Diff_Rotation_Position.x / calibration), 0);
    }
}
