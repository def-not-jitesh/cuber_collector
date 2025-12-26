using UnityEngine;

public class Player : MonoBehaviour {
	
	[SerializeField] float PlayerSpeed = 10f;
	[SerializeField] float PlayerSideSpeed = 300f;

	void Update() {
		
		transform.position += Vector3.forward * PlayerSpeed * Time.deltaTime;

		if (Input.GetKey(KeyCode.A)) {
			transform.position += Vector3.left * PlayerSideSpeed * Time.deltaTime;
		}

		if (Input.GetKey(KeyCode.D)) {
			transform.position += Vector3.right * PlayerSideSpeed * Time.deltaTime;
		}
	}
}
