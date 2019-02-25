using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public enum Rarity
{
	Common,
	Rare,
	Epic,
	Legendary
}


public class HeroAsset : ScriptableObject
{
	[Header("Hero UI")]
	public string heroName;
	public Sprite heroAvatar;
	public Sprite heroPortrait;
	


	[Header("Hero Logic")]
	public int maxHealth;
	public int attack;
	public int defense;
	public float chance;

	public Rarity rarity;

	[Header("Use Ability Asset 2")]
	public List<AbilityAsset2> abilityAsset2;
	//public List<AbilityAsset> abilityAsset;

	


}
