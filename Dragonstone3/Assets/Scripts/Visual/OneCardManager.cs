using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// holds the refs to all the Text, Images on the card
public class OneCardManager : MonoBehaviour {

    public HeroAsset heroAsset;
    public OneCardManager PreviewManager;

    [Header("Text Component References")]
    public Text NameplateText;
    public Text DefenseText;
    public Text ShieldText;
    public Text HealthText;
    public Text AttackText;

    [Header("Image References")]
    
    public Image CardBodyImage;
    public Image AvatarImage;
    public Image NameplateImage;
    public Image DefenseImage;
    public Image AttackImage;
    public Image HealthImage;
    public Image ShieldImage; 
    public Image BuffImage; 
    

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
