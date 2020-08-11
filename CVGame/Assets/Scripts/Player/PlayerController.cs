/**
Author : Alexandre Bernard
**/

using UnityEngine.EventSystems;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    #region Variables
    public LayerMask movementMask;
    public Interactable focus;
    public bool canMove = true;

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


        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0) && canMove)
        {
            if (Physics.Raycast(ray, out hit, 100, movementMask))
            {
                //Move player to what was hit
                motor.MoveToPoint(hit.point);

                //Stop focusing any object
                RemoveFocus();
            }
        }

        if (Input.GetMouseButtonDown(1) && canMove)
        {
            if (Physics.Raycast(ray, out hit, 100))
            {
                Interactable interactable = hit.collider.GetComponent<Interactable>();

                if (interactable != null)
                {
                    SetFocus(interactable);
                }

            }
        }

        if (Physics.Raycast(ray, out hit, 100) && canMove)
        {
            
            Interactable interactable = hit.collider.GetComponent<Interactable>();

            if (interactable != null && Time.time > interactable.nextFlashTime)
            {
                interactable.nextFlashTime = Time.time + 1;
                StartCoroutine(FlashColor(interactable));
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

    IEnumerator FlashColor(Interactable interactable)
    {
        float flashTime = 1;
        float flashSpeed = 4;

        Material mat = interactable.GetComponent<Renderer>().material;
        Color initialColor = mat.color;
        Color flashColor = Color.green;

        float flashTimer = 0;

        while (flashTimer < flashTime)
        {
            mat.color = Color.Lerp(initialColor, flashColor, Mathf.PingPong(flashTimer * flashSpeed, 1));

            flashTimer += Time.deltaTime;
            yield return null;
        }
    }

    #endregion
}
