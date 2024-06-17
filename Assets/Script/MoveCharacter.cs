using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
	[SerializeField] float speed = 30;
	[SerializeField] Rigidbody rb;

	[SerializeField]
	float inputThreshold = 0.01f;
	void Update()
	{
		float moveX = Input.GetAxis("Horizontal");
		float moveZ = Input.GetAxis("Vertical");

		if (moveX > inputThreshold || moveX < -inputThreshold || moveZ > inputThreshold || moveZ < -inputThreshold)
		{
			rb.AddForce(new Vector3(moveX, 0, moveZ) * speed * Time.deltaTime, ForceMode.VelocityChange);
		}
		else
		{
			rb.velocity = new Vector3(0, rb.velocity.y, 0);
		}
	}
}
