using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCharacter : MonoBehaviour
{
    public Character character;
    public GameObject SelectedCharacter;
    public GameObject Canvas;
    
    // Start is called before the first frame update

    public void OnClick()
    {
        DataManager.Instance.currentCharacter = character;
        SelectedCharacter.SetActive(false);
        Canvas.SetActive(true);
    }
}
