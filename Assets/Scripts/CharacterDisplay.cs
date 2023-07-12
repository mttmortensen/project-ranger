using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterDisplay : MonoBehaviour
{
    public Image characterImage; // The image component that displays the character's PNG

    // This method should be called when the selected character changes
    public void UpdateDisplay(Sprite characterSprite)
    {
        // Update the character image
        characterImage.sprite = characterSprite;
    }
}
