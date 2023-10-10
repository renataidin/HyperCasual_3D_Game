using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private CharacterController CharacterController;
    public float speed = 5f;

    private void Awake()
    {
        CharacterController = GetComponent<CharacterController>();
    }

    private void FixedUpdate()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input. GetAxis("Vertical"));
        CharacterController.Move(move * Time.fixedDeltaTime * speed);
    }
}
