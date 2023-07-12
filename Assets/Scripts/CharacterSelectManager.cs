using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectManager : MonoBehaviour
{
    public Character[] characters;
    public GameObject characterButtonPrefab;
    public Transform characterButtonContainer;
    public CharacterDisplay characterDisplay;

    private Character selectedCharacter;

    void Start()
    {
        for (int i = 0; i < characters.Length; i++)
        {
            CharacterButton characterButton = Instantiate(characterButtonPrefab, characterButtonContainer).GetComponent<CharacterButton>();
            characterButton.Setup(characters[i], this);
        }

        // Selects the first character at the start
        if (characters.Length > 0)
        {
            UpdateDisplay(characters[0]);
        }
    }

    public void UpdateDisplay(Character character)
    {
        selectedCharacter = character;
        characterDisplay.UpdateDisplay(character);
    }

    public void SelectCharacter()
    {
        // Do something with selectedCharacter
    }
}


