/**
Author : Alexandre Bernard
**/

using UnityEngine;

public class CameraController : MonoBehaviour
{
    #region Variables
    public Transform target;

    #region Camera position
    public Vector3 offset;
    public float pitch = 2f;
    #endregion

    #region Zoom
    public float zoomSpeed = 4f;
    public float minZoom = 5f;
    public float maxZoom = 15f;
    
    float currentZoom = 10f;
    #endregion

    #region Camera Rotation
    public float yawSpeed = 100f;
    
    float currentYaw = 0f;
    #endregion

    #endregion

    #region Unity Methods

    void Update()
    {
        currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
        currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);

        currentYaw += Input.GetAxis("Horizontal") * yawSpeed * Time.deltaTime;
    }

    void LateUpdate()
    {
        transform.position = target.position - offset * currentZoom;
        transform.LookAt(target.position + Vector3.up * pitch);

        transform.RotateAround(target.position, Vector3.up, currentYaw);
    }
	#endregion
}
