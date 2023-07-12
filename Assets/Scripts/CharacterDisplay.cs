using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterDisplay : MonoBehaviour
{
    public Image characterImage;
    public TextMeshProUGUI characterName;

    public void UpdateDisplay(Character character)
    {
        characterImage.sprite = character.characterFace;
        characterName.text = character.characterName;
    }
}

