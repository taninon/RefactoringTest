using UnityEngine;

public class SpritTemporaryVariableSubject : MonoBehaviour
{
	[SerializeField] private float speed = 5f;
	[SerializeField] private Rigidbody rigidbody;

	void Update()
	{
		float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
		float z = Input.GetAxis("Vertical") * Time.deltaTime * speed;

		rigidbody.AddForce(x, 0, z, ForceMode.Impulse);
	}
}
