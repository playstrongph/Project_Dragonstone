using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// holds the refs to all the Text, Images on the card
public class HeroCardManager : MonoBehaviour {

    public HeroAsset heroAsset;
    public HeroCardManager PreviewManager;

    [Header("Text Component References")]    
    //Hero Panel UI Text
    public Text DefenseText;
    public Text ShieldText;
    public Text HealthText;
    public Text AttackText;

    //Skill Panel UI Text
    public Text portraitText;
    public Text attackCDText;
    public Text specialCDText;
    public Text ultimateCDText;

    [Header("Image References")]
    
    //Hero Panel UI IMages
    public Image frontCardBodyImage;
    public Image backCardBodyImage;
    public Image selectorImage;
    public Image avatarImage;    
    public Image defenseImage;
    public Image attackImage;
    public Image healthImage;
    public Image shieldImage; 

    //Skill Panel UI Images
    public Image heroPortrait;
    public Image attackSkillImage;
    public Image specialSkillImage;
    public Image ultimateSkillImage;

    
    [Header("Button References")]
    public Button attackButton;
    public Button specialButton;
    public Button ultimateButton;


    [Header("Panel References")]
    public GameObject heroPanel;
    public GameObject buffPanel;
    public GameObject skillPanel;
    

    // void Awake()
    // {
    //     if (heroAsset != null)
    //         ReadCardFromAsset();
    // }

    // private bool canBePlayedNow = false;
    // public bool CanBePlayedNow
    // {
    //     get
    //     {
    //         return canBePlayedNow;
    //     }

    //     set
    //     {
    //         canBePlayedNow = value;

    //         CardFaceGlowImage.enabled = value;
    //     }
    // }

    // public void ReadCardFromAsset()
    // {
    //     // universal actions for any Card
    //     // 1) apply tint
    //     if (heroAsset.characterAsset != null)
    //     {
    //         CardBodyImage.color = heroAsset.characterAsset.ClassCardTint;
    //         // CardFaceFrameImage.color = heroAsset.characterAsset.ClassCardTint;
    //         // CardTopRibbonImage.color = heroAsset.characterAsset.ClassRibbonsTint;
    //         // CardLowRibbonImage.color = heroAsset.characterAsset.ClassRibbonsTint;
    //     }
    //     else
    //     {
    //         //CardBodyImage.color = GlobalSettings.Instance.CardBodyStandardColor;
    //         CardFaceFrameImage.color = Color.white;
    //         //CardTopRibbonImage.color = GlobalSettings.Instance.CardRibbonsStandardColor;
    //         //CardLowRibbonImage.color = GlobalSettings.Instance.CardRibbonsStandardColor;
    //     }
    //     // 2) add card name
    //     NameplateText.text = heroAsset.name;
    //     // 3) add mana cost
    //    // ManaCostText.text = heroAsset.ManaCost.ToString();
    //     // 4) add description
    //    // DescriptionText.text = heroAsset.Description;
    //     // 5) Change the card graphic sprite
    //    // CardGraphicImage.sprite = heroAsset.CardImage;

    //     if (heroAsset.MaxHealth != 0)
    //     {
    //         // this is a creature
    //         AttackText.text = heroAsset.Attack.ToString();
    //         HealthText.text = heroAsset.MaxHealth.ToString();
    //     }

    //     if (PreviewManager != null)
    //     {
    //         // this is a card and not a preview
    //         // Preview GameObject will have OneCardManager as well, but PreviewManager should be null there
    //         PreviewManager.heroAsset = heroAsset;
    //         PreviewManager.ReadCardFromAsset();
    //     }
    // }
}
