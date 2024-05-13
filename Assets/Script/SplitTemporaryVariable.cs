using UnityEngine;

public class SplitTemporaryVariable : MonoBehaviour
{
	[SerializeField] private float speed = 5f;
	[SerializeField] private Rigidbody rigidbody;

	private void Update()
	{
		Vector3 velocity = new Vector3();
		float velocityAxis;

		velocityAxis = Input.GetAxis("Vertical");
		velocity.y = velocityAxis;

		velocityAxis = Input.GetAxis("Horizontal");
		velocity.x = velocityAxis;

		rigidbody.velocity = velocity * speed;
	}
}
