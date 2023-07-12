using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterButton : MonoBehaviour
{
    public Image characterImage;
    private Character character;
    private CharacterSelectManager characterSelectManager;

    public void Setup(Character character, CharacterSelectManager manager)
    {
        this.character = character;
        this.characterSelectManager = manager;
        characterImage.sprite = character.characterFace;
        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        characterSelectManager.UpdateDisplay(character);
    }
}

