using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    #region Variables
    public LayerMask movementMask;

    Camera cam;
    PlayerMotor motor;
	#endregion

	#region Unity Methods
    void Start() {
        cam = Camera.main;
        motor = GetComponent<PlayerMotor>();
    }

    void Update() {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray,out hit, 100, movementMask))
            {
                //Move player to what was hit
                motor.MoveToPoint(hit.point);

                //Stop focusing any object
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                //Check if we hit and interactable

                //If we did set it as our focus

            }
        }
    }
	#endregion
}
