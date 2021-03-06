﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DebuffList {
	DecreaseAttack,
	DecreaseDefense,
	Unlucky,
	Unhealable,
	Silence,
	CrippledStrike,
	Stun,
	Taunt,
	Echo,
	Malaise,
	Poison,
	AntiBuff,
	Brand,
	Bomb,
	IncreaseCooldown,
	Oblivion,

	//AbilityRelatedDebuffs
	ChargeVitalityStun,
	GodsShieldUnlucky

	
}



public class DebuffAsset : ScriptableObject {

	[Header("Debuff Name")]
	public DebuffList debuff;

	public Sprite icon;

	[Header("Special Value - this can be bonus percentage, etc")]
	public int value;

	[TextArea(5,10)]
	public string description;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
