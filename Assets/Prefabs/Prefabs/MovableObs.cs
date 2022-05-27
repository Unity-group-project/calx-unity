using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableObs : MonoBehaviour
{
	public float distance = 5f; //Distance that moves the object
	public float distance2 = 10f;
	public bool vertical = true; //If the movement is horizontal or vertical
	public bool new_dist = true;
	public float speed = 3f;
	public float offset = 0f; //If yo want to modify the position at the start 

	private bool isHorizontal = true; //If the movement is out
	private Vector3 startPos;

	void Awake()
	{
		startPos = transform.position;
		if (vertical)
			transform.position += Vector3.up * offset;
		else
			transform.position += Vector3.right * offset;
	}

	void Update()
	{
		if (vertical)
		{
			if (new_dist)
			{
				if (isHorizontal)
				{
					if (transform.position.y < startPos.y + distance2)
					{
						transform.position += Vector3.up * Time.deltaTime * speed;
					}
					else
						isHorizontal = false;
				}
				else
				{
					if (transform.position.y > startPos.y)
					{
						transform.position -= Vector3.up * Time.deltaTime * speed;
					}
					else
						isHorizontal = true;
				}
			}
			else
            {
				if (isHorizontal)
				{
					if (transform.position.y < startPos.y + distance)
					{
						transform.position += Vector3.up * Time.deltaTime * speed;
					}
					else
						isHorizontal = false;
				}
				else
				{
					if (transform.position.y > startPos.y)
					{
						transform.position -= Vector3.up * Time.deltaTime * speed;
					}
					else
						isHorizontal = true;
				}

			}
		}
		else
		{
			if (new_dist)
			{
				if (isHorizontal)
				{
					if (transform.position.x < startPos.x + distance2)
					{
						transform.position += Vector3.right * Time.deltaTime * speed;
					}
					else
						isHorizontal = false;
				}
				else
				{
					if (transform.position.x > startPos.x)
					{
						transform.position -= Vector3.right * Time.deltaTime * speed;
					}
					else
						isHorizontal = true;
				}
			}
			else
            {
				if (isHorizontal)
				{
					if (transform.position.x < startPos.x + distance)
					{
						transform.position += Vector3.right * Time.deltaTime * speed;
					}
					else
						isHorizontal = false;
				}
				else
				{
					if (transform.position.x > startPos.x)
					{
						transform.position -= Vector3.right * Time.deltaTime * speed;
					}
					else
						isHorizontal = true;
				}
			}
		}
	}
}
