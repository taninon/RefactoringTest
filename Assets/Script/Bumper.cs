using UnityEngine;

public class Bumper : MonoBehaviour
{
	public float Bounce = 10f;

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Ball")
		{
			collision.rigidbody.AddForce(0f, Bounce / 6, -Bounce, ForceMode.Impulse);
		}
	}
}
