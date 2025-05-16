
using UnityEngine;

class CharacterController : MonoBehaviour
{

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

	}

}
