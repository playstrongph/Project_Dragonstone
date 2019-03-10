using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Reflection;

public class PlayerVisual : MonoBehaviour {

	public GameObject SpawnLocations;
	public GameObject SpawnPanelLocation;
	public DeckList deck;
	public HeroManagerTest heroPrefab;
	

	///<Private_Variables>
	HeroManagerTest heroGO;	
	GameObject pointerObject;	
	List<GameObject> teamHeroes = new List<GameObject>();

	
	void Awake(){
		StartCoroutine(InitHeroesRoutine());
	}
	
	
	public IEnumerator InitHeroesRoutine ()
	{

		

		if (deck.heroes != null)
		{
			for (int i = 0; i < deck.heroes.Count; i++)
			{
				yield return new WaitForSeconds (0.2f);
				Transform spawnLocation = SpawnLocations.GetComponent<SameDistanceChildren>().Children[i].transform;
				heroPrefab.heroAsset = deck.heroes[i];
				heroGO =  Instantiate(heroPrefab, spawnLocation.position, spawnLocation.rotation, transform);

				//Fix Skill Panel Location
				GameObject go = heroGO.transform.gameObject;
				heroGO.SkillsUI.transform.SetParent(SpawnPanelLocation.transform);
				heroGO.SkillsUI.transform.position = new Vector3 (0,-4,0);
				heroGO.SkillsUI.transform.SetParent(go.transform);

				

// 				HeroManager heroManager = heroGO.GetComponent<HeroManager>();
// 				heroManager.heroName = deck.heroes[i].heroName;
// 				heroManager.image = deck.heroes[i].image;
// 				heroManager.maxHealth = deck.heroes[i].maxHealth;
// 				heroManager.attack = deck.heroes[i].attack;
// 				heroManager.defense = deck.heroes[i].defense;
// 				heroManager.chance = deck.heroes[i].chance;

// 				heroManager.rarity = deck.heroes[i].rarity;

// 				heroManager.player = this;
// 				heroManager.tag = this.tag;

// 				heroGO.GetComponentInChildren<Image>().sprite = deck.heroes[i].image;
// 				heroGO.name = heroManager.heroName;
// 				heroGO.GetComponentInChildren<OverheadText>().FloatingText(heroGO.name.ToString());
				


// //add the abilities script to hero object
// /*
// 				for (int j = 0; j < deck.heroes[i].abilityAsset.Count; j++)
// 				{
// 					string spellScriptName = deck.heroes[i].abilityAsset[j].abilityEffect;
// 					if (spellScriptName != null) {
// 						heroManager.abilityAssets.Add(deck.heroes[i].abilityAsset[j]);
// 					}
// 				}
// */

// 				for (int j = 0; j < deck.heroes[i].abilityAsset2.Count; j++)
// 				{
// 					string spellScriptName = deck.heroes[i].abilityAsset2[j].abilityEffect;
// 					if (spellScriptName != null) {
// 						heroManager.abilityAssets.Add(deck.heroes[i].abilityAsset2[j]);
						
// 					}

					
// 				}
// 				//heroManager.UpdateUI();
// 				//heroManager.CreateHeroPanel();

// 				//Set original reference values
// 				heroManager.origHealth = heroManager.maxHealth;
// 				heroManager.origAttack = heroManager.attack;
// 				heroManager.origDefense = heroManager.defense;
// 				heroManager.origChance = heroManager.chance;
// 				heroManager.origShield = heroManager.shield;


			}

		}

		yield return null;

	}//InitHeroes

}
