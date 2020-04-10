///Created By Augmented Startups
///Date 8 April 2020
///Ritesh Kanjee
///Visit AugmentedStartups.com for Full Tutorial 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePerspective : MonoBehaviour
{
    public float calibration_x = 12.4f;         // Calibration parameter for the x_axis for rotation
    public float calibration_y = 12.4f;         // Calibtation parameter for the y axis for rotation
    public GameObject FaceCube;
    public Vector3 Zero_Rotation_Position;      // Set initial detection as Start rotation
    public Vector3 Current_Rotation_Position;   // Continuous detection position
    public Vector3 Diff_Rotation_Position;      // Delta detection position

    void Awake()
    {
        Zero_Rotation_Position = FaceCube.transform.position;
    }

    void Update()
    {
        Current_Rotation_Position = FaceCube.transform.position;                                                                                //Continuous position of the face
        Diff_Rotation_Position = Current_Rotation_Position - Zero_Rotation_Position;                                                            //Delta position for the rotation parameter

        this.transform.position = new Vector3((Diff_Rotation_Position.x / 1), (Diff_Rotation_Position.y / 1)+91, -689);                         // Change the position of the camera relative to the detected face
        this.transform.eulerAngles = new Vector3((Diff_Rotation_Position.y / calibration_y), -(Diff_Rotation_Position.x / calibration_x), 0);   //Change the Rotation of the camera relative to the detected face
    }
}
