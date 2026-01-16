using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	void OnCollisionEnter(Collision collisionInfo) {
		
		if (collisionInfo.collider.tag == "collectable") {
			Debug.Log("we ate a collectable");
			Destroy(collisionInfo.gameObject);
		} 

		if (collisionInfo.collider.tag == "obstacle") {
			Debug.Log("game over");
		}
	}
}
