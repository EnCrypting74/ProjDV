using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForkControl : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;
    public float gravity = -9.8f;

    private CharacterController _charController;

    void Start()
    {
        _charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float DeltaX = Input.GetAxis("Horizontal")*speed;
        float DeltaZ = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(DeltaX,0,DeltaZ);
        movement = Vector3.ClampMagnitude(movement,speed);

        movement.y = gravity;
        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        _charController.Move(movement);
    }
}
