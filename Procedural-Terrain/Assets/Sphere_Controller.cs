using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere_Controller : MonoBehaviour
{
    [SerializeField, Range(200f, 1000f)] float maxSpeed = 350;
    void FixedUpdate () {
        Vector3 velocity = new Vector3(0, 0, 0);
		Vector2 playerInput;
		playerInput.x = Input.GetAxis("Horizontal");
		playerInput.y = Input.GetAxis("Vertical");
        playerInput = Vector2.ClampMagnitude(playerInput, 1f);
		
        Vector3 acceleration = new Vector3(playerInput.x, 0f, playerInput.y) * maxSpeed;
		velocity += acceleration * Time.deltaTime;
		Vector3 displacement = velocity * Time.deltaTime;
		transform.localPosition += displacement;
	}
}
