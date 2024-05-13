using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class SelectCharacter : MonoBehaviour
{
    public Character character;
    public GameObject SelectedCharacter;
    public GameObject Canvas;
    public GameObject KnightSprite;
    public GameObject ElfSprite;
    public GameObject DwarfSprite;
    
    // Start is called before the first frame update

    public void OnClick()
    {
        GameManager.Instance.selectedCharacter = character;

        switch (GameManager.Instance.selectedCharacter)
        {
            case Character.Knight:
                KnightSprite.SetActive(true);
                ElfSprite.SetActive(false);
                DwarfSprite.SetActive(false);
                break;
            case Character.Elf:
                KnightSprite.SetActive(false);
                ElfSprite.SetActive(true);
                DwarfSprite.SetActive(false);
                break;
            case Character.Dwarf:
                KnightSprite.SetActive(false);
                ElfSprite.SetActive(false);
                DwarfSprite.SetActive(true);
                break;
            default:
                KnightSprite.SetActive(false);
                ElfSprite.SetActive(false);
                DwarfSprite.SetActive(false);
                break;
        }

        SelectedCharacter.SetActive(false);
        Canvas.SetActive(true);
    }
}
