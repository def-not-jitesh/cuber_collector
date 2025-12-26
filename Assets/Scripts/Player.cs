using UnityEngine;

public class Player : MonoBehaviour {
	
	Rigidbody rb;

	Vector3 moveForward, moveLeft, moveRight;

	[SerializeField] float PlayerSpeed = 10f;
	[SerializeField] float PlayerSideSpeed = 300f;

	void Start() {
		moveForward = Vector3.forward * PlayerSpeed * Time.deltaTime;
		moveLeft = Vector3.left * PlayerSideSpeed * Time.deltaTime;
		moveRight = Vector3.right * PlayerSideSpeed * Time.deltaTime;

		rb = GetComponent<Rigidbody>();

	}

	void Update() {
		
		rb.MovePosition(rb.position + moveForward);

		if (Input.GetKey(KeyCode.A)) {
			rb.MovePosition(rb.position + moveLeft);
		}

		if (Input.GetKey(KeyCode.D)) {
			rb.MovePosition(rb.position + moveRight);
		}
	}
}
