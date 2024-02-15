using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class characterMovement : MonoBehaviour
{
    private CharacterController characterController;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate(){
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
        characterController.Move(move*Time.deltaTime*speed);
    }
}
