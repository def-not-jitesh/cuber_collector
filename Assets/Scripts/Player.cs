using UnityEngine;

public class Player : MonoBehaviour {
	
	[SerializeField] Rigidbody rb;
	[SerializeField] float PlayerSpeed = 10f;

	void Update() {
		rb.AddForce(0, 0, PlayerSpeed * Time.deltaTime);
	}
}
