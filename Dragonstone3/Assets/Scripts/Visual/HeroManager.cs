using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

// holds the refs to all the Text, Images on the card

public class HeroManager : MonoBehaviour {

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

    
    [Header("Button References")]
    public List<Button> SkillButtons;
    public List<Text> SkillCDTexts;
    private List<SkillButtonPreview> SkillButtonPreviews;
    


    [Header("Prefab References")]    
    public GameObject SkillsUI;
    public Button SkillButton;
    
    
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

            //CardFaceGlowImage.enabled = value;
        }
    }

    public void ReadHeroFromAsset()
    {

        //FORM HERO GAMEOBJECT STRUCTURE FIRST
        
        
        SkillsUI = Instantiate(SkillsUI, transform.parent);

        SkillsUI.transform.SetParent(this.transform);

        int skillButtonCount = heroAsset.abilityAsset2.Count;


        //GameObject skillButtonParent = GameObject.Find("HeroCard/SkillsUI(Clone)/SkillCanvas/SkillPanelUI/SkillButtonPanel");
        GameObject skillButtonParent = GameObject.Find("SkillButtonPanel");

        for(int i = 0; i < skillButtonCount; i++){

            Button temp = Instantiate(SkillButton, skillButtonParent.transform); 
            SkillCDTexts.Add(temp.GetComponentInChildren<Text>());
            SkillButtons.Add(temp);            

        }

        // HeroPortrait = GameObject.Find("HeroCard/SkillsUI(Clone)/SkillCanvas/SkillPanelUI/HeroPortraitMask/HeroPortrait").GetComponent<Image>();
        // PortraitText = GameObject.Find("HeroCard/SkillsUI(Clone)/SkillCanvas/SkillPanelUI/HeroPortraitName/PortraitText").GetComponent<Text>();

        HeroPortrait = GameObject.Find("HeroPortrait").GetComponent<Image>();
        PortraitText = GameObject.Find("PortraitText").GetComponent<Text>();
        

        
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

        for(int i = 0; i < skillButtonCount; i++){
           SkillButtons[i].image.sprite = heroAsset.abilityAsset2[i].icon;
           SkillCDTexts[i].text = heroAsset.abilityAsset2[i].abilityCoolDown.ToString();

        
        }     
        
    }//ReadHeroFromAsset
   
}
