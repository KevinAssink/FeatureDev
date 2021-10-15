using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
	[SerializeField] private float _startHealth;
	private float _currentHealth;
	public float CurrentHealth
	{
		get { return _currentHealth; }
	}

	private void Awake()
	{
		_currentHealth = _startHealth;
	}
	private void Update()
	{
		
	}
	public void TakeDamage(float dmg)
	{
		_currentHealth -= dmg;

		HandleTakeDmg();
		
		if (_currentHealth <= 0){
			Die();
		}
		
	}

	protected virtual void HandleTakeDmg()
	{
		print("ik krijg schade");
	}
	protected virtual void Die()
	{
		print("die");
	}

}

	