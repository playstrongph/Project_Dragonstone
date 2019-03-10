using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

// holds the refs to all the Text, Images on the card

public class HeroPreview : MonoBehaviour {

    public HeroAsset heroAsset;
    // public HeroManager PreviewManager;
    // public bool isCardPreview;

    [Header("Text Component References")]    
    //Hero UI Text
    public Text DefenseText;
    // public Text ShieldText;
    public Text HealthText;
    public Text AttackText;

    //Skill Panel UI Text
    // public Text PortraitText;
    

    [Header("Image References")]
    
    //Hero Panel UI IMages
    // public Image FrontCardBodyImage;
    // public Image BackCardBodyImage;
    public Image SelectorImage;
    public Image AvatarImage;    
    public Image DefenseImage;
    public Image AttackImage;
    public Image HealthImage;
    //public Image ShieldImage;
    //public Image HeroGlow; 

    //Skill Panel UI Images
    //public Image HeroPortrait;
    

    
    // [Header("Button References")]
    // public List<Button> SkillButtons;
    // public List<Text> SkillCDTexts;
    // private List<SkillButtonPreview> SkillButtonPreviews;
    


    // [Header("Prefab References")]
    // public GameObject HeroUI;
    // public GameObject BuffUI;
    // public GameObject SkillsUI;
    // public Button SkillButton;
    // public GameObject HeroBuffUI;
    
    

    void Awake()
    {
       
                ReadHeroFromAsset();         

            
    }

    // private bool heroIsActive = false;
    // public bool HeroIsActive
    // {
    //     get
    //     {
    //         return heroIsActive;
    //     }

    //     set
    //     {
    //         heroIsActive = value;

    //         //CardFaceGlowImage.enabled = value;
    //     }
    // }

    public void ReadHeroFromAsset()
    {

        //FORM HERO GAMEOBJECT STRUCTURE FIRST
        
        
        // SkillsUI = Instantiate(SkillsUI, transform.parent);

        // SkillsUI.transform.SetParent(this.transform);

        // int skillButtonCount = heroAsset.abilityAsset2.Count;


        // //GameObject skillButtonParent = GameObject.Find("HeroCard/SkillsUI(Clone)/SkillCanvas/SkillPanelUI/SkillButtonPanel");
        // GameObject skillButtonParent = GameObject.Find("SkillButtonPanel");

        // for(int i = 0; i < skillButtonCount; i++){

        //     Button temp = Instantiate(SkillButton, skillButtonParent.transform); 
        //     SkillCDTexts.Add(temp.GetComponentInChildren<Text>());
        //     SkillButtons.Add(temp);            

        // }

        // HeroPortrait = GameObject.Find("HeroCard/SkillsUI(Clone)/SkillCanvas/SkillPanelUI/HeroPortraitMask/HeroPortrait").GetComponent<Image>();
        // PortraitText = GameObject.Find("HeroCard/SkillsUI(Clone)/SkillCanvas/SkillPanelUI/HeroPortraitName/PortraitText").GetComponent<Text>();

        // HeroPortrait = GameObject.Find("HeroPortrait").GetComponent<Image>();
        // PortraitText = GameObject.Find("PortraitText").GetComponent<Text>();
        

        
        //ASSIGN VALUES FROM SO
        //Text values

        heroAsset = GetComponentInParent<HeroManagerTest>().heroAsset;

        //this.name = heroAsset.heroName;
        DefenseText.text = heroAsset.defense.ToString();
        HealthText.text = heroAsset.maxHealth.ToString();
        AttackText.text = heroAsset.attack.ToString();
        // PortraitText.text = heroAsset.heroName;

        //Image sprites
        AvatarImage.sprite = heroAsset.heroAvatar;
        // HeroPortrait.sprite = heroAsset.heroPortrait;        

        // for(int i = 0; i < skillButtonCount; i++){
        //    SkillButtons[i].image.sprite = heroAsset.abilityAsset2[i].icon;
        //    SkillCDTexts[i].text = heroAsset.abilityAsset2[i].abilityCoolDown.ToString();

        // //    //set the Preview Image and Mana-Cost           
        // //    Image skillPreview = SkillButtons[i].GetComponent<HoverPreview>().previewGameObject.GetComponent<Image>();
        // //    skillPreview.sprite = heroAsset.abilityAsset2[i].skillPreview;
        // //    //skillPreview.SetNativeSize();           

        // //    //Skill Cost
        // //    SkillButtons[i].GetComponent<HoverPreview>().skillCostText.GetComponent<Text>().text = heroAsset.abilityAsset2[i].abilityCoolDown.ToString();

        // //    //Skill Description
        // //    SkillButtons[i].GetComponent<HoverPreview>().skillDescriptionText.GetComponent<Text>().text = heroAsset.abilityAsset2[i].description; 

        // //    skillPreview.preserveAspect = true;



        //    //SkillButtons[i].GetComponentInChildren<SkillButtonPreview>().gameObject.SetActive(false);
        // }

      
        //used for hero previews
        // if (PreviewManager != null)
        // {
        //     // this is a card and not a preview
        //     // Preview GameObject will have OneCardManager as well, but PreviewManager should be null there
        //     PreviewManager.heroAsset = heroAsset;
        //     PreviewManager.ReadHeroFromAsset();
        // }
    }//ReadHeroFromAsset

   
}
