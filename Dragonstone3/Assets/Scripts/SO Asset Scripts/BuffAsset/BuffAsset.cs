using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BuffList {
	
	Defend,
	Immunity,
	IncreaseAttack,
	IncreaseDefense,
	Shield,
	Lucky,
	CriticalStrike,
	Recovery,
	Reflect,
	Endure,
	Revenge,
	Threat,
	ExtraTurn,
	ReduceCooldown,
	ProtectSoul
	
}


public class BuffAsset : ScriptableObject {

	[Header("Buff Name")]
	public BuffList buff;
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
