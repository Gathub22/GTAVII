
using UnityEngine;

class CharacterController : MonoBehaviour
{
	public int hp = 3;
  public float JumpStrength;
  public float DashStrength = 10f;
  public float DashCooldown = 5f;

  private float lastDashTime = -Mathf.Infinity;
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
		rb.AddForce(Input.GetAxis("Vertical") * Vector3.forward * Time.deltaTime);

		if (Input.GetKeyDown(KeyCode.LeftShift) && Time.time >= lastDashTime + DashCooldown)
    {
       rb.AddForce(transform.forward * DashStrength, ForceMode.VelocityChange);
       lastDashTime = Time.time;
    }

		if (hp <= 0)
		{
			print("Game Over")
			Destroy(gameObject);
  	}
}
