using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	[SerializeField] Transform player;
	Vector3 offset = new Vector3(0, 3, -9);

	void LateUpdate() {
		transform.position = player.transform.position + offset;
	}
}
