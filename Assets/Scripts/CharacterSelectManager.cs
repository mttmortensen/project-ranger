using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class CharacterSelectManager : MonoBehaviour
{
    public static CharacterSelectManager instance; // Singleton instance
    public GameObject buttonPrefab;
    public Transform buttonContainer;

    public Image selectedCharacterImage; // The image component that displays the selected character
    
    public List<Character> characterList;

    private void Awake()
    {
        // Set up the singleton instance
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        foreach (Character character in characterList)
        {
            // Instantiate a new button
            GameObject buttonObj = Instantiate(buttonPrefab, buttonContainer);

            // Get the CharacterButton component of the new button
            CharacterButton button = buttonObj.GetComponent<CharacterButton>();

            // Set the character image of the button
            button.characterImage.sprite = character.characterFace;

            // Set the onClick event of the button
            button.button.onClick.AddListener(() => characterDisplay.SelectCharacter(character.characterFace));
        }
    }

    // This method is called by the character buttons when they are clicked
    public void SelectCharacter(Sprite characterSprite)
    {
        // Update the selected character display
        selectedCharacterImage.sprite = characterSprite;
    }
}


