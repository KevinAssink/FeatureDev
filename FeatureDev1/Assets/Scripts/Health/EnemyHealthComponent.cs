using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthComponent : HealthComponent
{
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			TakeDamage(1);
		}
	}

	protected override void HandleTakeDmg()
	{
		base.HandleTakeDmg();
		// update healthbar
		print("Enemy: " + CurrentHealth);
	}

	protected override void Die()
	{
		base.Die();
		Destroy(gameObject);
	}
}
	
