/**
Author : Alexandre Bernard
**/

using UnityEngine.EventSystems;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    #region Variables
    public LayerMask movementMask;
    public Interactable focus;

    Camera cam;
    PlayerMotor motor;
	#endregion

	#region Unity Methods
    void Start() {
        cam = Camera.main;
        motor = GetComponent<PlayerMotor>();
    }

    void Update() {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit, 100, movementMask))
            {
                //Move player to what was hit
                motor.MoveToPoint(hit.point);

                //Stop focusing any object
                RemoveFocus();
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit, 100))
            {
                Interactable interactable = hit.collider.GetComponent<Interactable>();

                if (interactable != null)
                {
                    SetFocus(interactable);
                }

            }
        }
    }

    void SetFocus(Interactable newFocus)
    {
        if (newFocus != focus)
        {
            if (focus != null)
                focus.OnDeFocused();

            focus = newFocus;
            motor.FollowTarget(newFocus);
        }
        focus.OnFocused(transform);
    }

    void RemoveFocus()
    {
        if (focus != null)
            focus.OnDeFocused();
        focus = null;
        motor.StopFollowingTarget();
    }
	#endregion
}
