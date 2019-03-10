using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

// holds the refs to all the Text, Images on the card

public class HeroManagerTest : MonoBehaviour {

    public HeroAsset heroAsset;
    

    [Header("Text Component References")]    
    //Hero UI Text
    public Text DefenseText;
    public Text ShieldText;
    public Text HealthText;
    public Text AttackText;

    //Skill Panel UI Text
    public Text PortraitText;
    

    [Header("Image References")]
    
    //Hero Panel UI IMages    
    public Image SelectorImage;
    public Image AvatarImage;    
    public Image DefenseImage;
    public Image AttackImage;
    public Image HealthImage;
    public Image ShieldImage;
    public Image HeroGlow; 

    //Skill Panel UI Images
    public Image HeroPortrait;   

    
    [Header("Panel References")]
    public List<Button> SkillButtons;
    public List<GameObject> SkillButtonPreviews;
    
    public GameObject Buffpanel;
    public GameObject SkillsUI;

    //private List<AbilityAsset2> SkillAssets;
    
    
    void Awake()
    {       
        ReadHeroFromAsset();            
    }

    private bool heroIsActive = false;
    public bool HeroIsActive
    {
        get
        {
            return heroIsActive;
        }

        set
        {
            heroIsActive = value;

           
        }
    }

    public void ReadHeroFromAsset()
    {

        
        // HeroPortrait = GameObject.Find("HeroPortrait").GetComponent<Image>();
        // PortraitText = GameObject.Find("PortraitText").GetComponent<Text>();     

        
        //ASSIGN VALUES FROM SO
        //Text values
        this.name = heroAsset.heroName;
        DefenseText.text = heroAsset.defense.ToString();
        HealthText.text = heroAsset.maxHealth.ToString();
        AttackText.text = heroAsset.attack.ToString();
        PortraitText.text = heroAsset.heroName;

        //Image sprites
        AvatarImage.sprite = heroAsset.heroAvatar;
        HeroPortrait.sprite = heroAsset.heroPortrait;                 
        
        //Get references to SO abilities
        int abilityCount = heroAsset.abilityAsset2.Count;

        for(int i = 0; i<abilityCount; i++){
            
            
            
            //Skillbuttons
            SkillButtons[i].image.sprite = heroAsset.abilityAsset2[i].icon;
           
            SkillButtons[i].GetComponentInChildren<Text>().text = heroAsset.abilityAsset2[i].abilityCoolDown.ToString();
            
            
            //SkillButtonPreview
            SkillButtonPreviews[i].GetComponent<Image>().sprite = heroAsset.abilityAsset2[i].skillPreview;
            
            
            //Skill Description and SkillPreview Text
            Text[] texts = SkillButtonPreviews[i].GetComponentsInChildren<Text>();
           
            texts[0].text = heroAsset.abilityAsset2[i].abilityCoolDown.ToString();
            texts[1].text = heroAsset.abilityAsset2[i].description.ToString();
           
        }

        SkillsUI.SetActive(false);


    }//ReadHeroFromAsset
   
}
