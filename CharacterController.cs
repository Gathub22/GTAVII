
using UnityEngine;

class CharacterController : MonoBehaviour
{
	public int hp = 3;

	public float JumpStrength;
	private Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void Update()
	{

		if (Input.GetKey(Input.Spacebar))
		{
			rb.AddForce(Vector3.up * JumpStrength * Time.deltaTime);
		}

		rb.AddForce(Input.GetAxis("Horizontal") * Vector3.right * Time.deltaTime);

		if (hp <= 0)
		{
			print("Game Over")
			Destroy(gameObject);
		}
  }
}
