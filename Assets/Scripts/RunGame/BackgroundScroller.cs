using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunGame
{
	public class BackgroundScroller : MonoBehaviour 
	{
		MeshRenderer renderer;

		float xOffset;

		public float scrollingSpeed;

		// Use this for initialization
		void Start () 
		{
			xOffset = 0;
			renderer = GetComponent<MeshRenderer>();
		}

		// Update is called once per frame
		void Update () 
		{
			xOffset += Time.deltaTime * scrollingSpeed;
			Vector2 offset = new Vector2(xOffset, 0);
			renderer.material.SetTextureOffset("_MainTex", offset);
		}
	}
}
