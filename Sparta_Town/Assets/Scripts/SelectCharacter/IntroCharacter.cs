using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroCharacter : MonoBehaviour
{
    public GameObject KnightPrefabs;
    public GameObject ElfPrefabs;
    public GameObject DwarfPrefabs;
    
    // Start is called before the first frame update
    void Start()
    {
        Character selectedCharacter = GameManager.Instance.selectedCharacter;

        switch (selectedCharacter)
        {
            case Character.Knight:
                KnightPrefabs.SetActive(true);
                break;
            case Character.Elf:
                ElfPrefabs.SetActive(true);
                break;
            case Character.Dwarf:
                DwarfPrefabs.SetActive(true);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
