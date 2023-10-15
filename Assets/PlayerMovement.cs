using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private CharacterController CharacterController;
    [SerializeField] private Joystick joystick;
    public float speed = 5f;

    private void Awake()
    {
        CharacterController = GetComponent<CharacterController>();
    }

    private void FixedUpdate()
    {
        // Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 move = new Vector3(joystick.Horizontal, 0, joystick.Vertical);
        CharacterController.Move(move * Time.fixedDeltaTime * speed);

        if (move != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(move, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, 750 * Time.fixedDeltaTime);
        }
    }
}
