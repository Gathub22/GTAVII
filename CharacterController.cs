
using UnityEngine;

class CharacterController : MonoBehaviour
{
	public int hp = 3;

	void Start()
	{

	}

	void Update()
	{
		if (hp <= 0)
        {
			print("Game Over")
            Destroy(gameObject);
        }
    }

}
