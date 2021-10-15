using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _arrivalThreshold;

    private Path _path;
    private Waypoint _currentWaypoint;

    private void Awake()
    {
        SetupPath();
    }

    private void Update()
    {
        Vector3 heightCorrectedWaypointPosition = _currentWaypoint.GetHeightCorrectedPosition(transform.position.y);
        float distanceToWaypoint = Vector3.Distance(transform.position, heightCorrectedWaypointPosition);

        if (distanceToWaypoint <= _arrivalThreshold)
        {
            if (_currentWaypoint == _path.GetPathEnd())
            {
                PathComplete();
            }
            else
            {
                _currentWaypoint = _path.GetNextWaypoint(_currentWaypoint);
                transform.LookAt(_currentWaypoint.GetHeightCorrectedPosition(transform.position.y));
            }
        }
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
    private void SetupPath()
    {
        _path = FindObjectOfType<Path>();
        _currentWaypoint = _path.GetPathStart();
        transform.LookAt(_currentWaypoint.GetHeightCorrectedPosition(transform.position.y));
    }
    private void PathComplete()
	{
        print("eindpunt!");
        _speed = 0;
    

        FindObjectOfType<PlayerHealthComponent>().TakeDamage(1);
        Destroy(gameObject);
	}

}
