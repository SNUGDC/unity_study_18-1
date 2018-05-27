using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunGame
{
	public class CharacterManager : MonoBehaviour 
	{
		bool isGround = false;

		float ySpeed;

		public float jumpPower = 5;

		private float gravity = -12f;

		void Update()
		{
			if (!isGround)
			{
				ySpeed += gravity * Time.deltaTime;
				transform.position += new Vector3(0, ySpeed * Time.deltaTime, 0);
			}

			if (isGround & Input.GetKeyDown(KeyCode.Space))
			{
				Jump();
			}
		}

		void Jump()
		{
			isGround = false;
			ySpeed = jumpPower;
		}

		void OnTriggerEnter(Collider coll)
		{
			isGround = true;
			ySpeed = 0;
		}
	}
}
