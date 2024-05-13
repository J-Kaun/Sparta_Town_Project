using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputNameManager : MonoBehaviour
{
    public InputField characterNameInputField;
    
    public void OnGameStart()
    {
        PlayerPrefs.SetString("CharacterName", characterNameInputField.text);
    }
}
