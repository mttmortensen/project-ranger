using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterButton : MonoBehaviour
{
    public Image characterImage; // The image component that displays the character's PNG

    // This method should be called when the button is clicked
    public void OnClick()
    {
        // Notify the character select manager that this character has been selected
        CharacterSelectManager.instance.SelectCharacter(characterImage.sprite);
    }
}
