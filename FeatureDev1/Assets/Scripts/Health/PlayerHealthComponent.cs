using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthComponent : HealthComponent
{
	[SerializeField] private PlayerHealthUI _playerHealthUI;
	private void Start()
	{
		_playerHealthUI.UpdateUI(CurrentHealth);
	}
	protected override void HandleTakeDmg()
	{
		base.HandleTakeDmg();
		_playerHealthUI.UpdateUI(CurrentHealth);
	}
	protected override void Die()
	{
		base.Die();
		print("Next level/game over");	
	}
}
