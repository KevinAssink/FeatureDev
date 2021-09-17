using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiles : MonoBehaviour
{ 

    [SerializeField]private bool _isBuildable;

	public bool GetBuildable()
	{
		return _isBuildable;
	}
}
