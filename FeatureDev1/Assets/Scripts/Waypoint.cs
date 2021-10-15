using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    public Vector3 GetPosition()
	{
		return transform.position;
	}

	public Vector3 GetHeightCorrectedPosition(float yPos)
	{
		return new Vector3(transform.position.x, yPos, transform.position.z);
	}
}
