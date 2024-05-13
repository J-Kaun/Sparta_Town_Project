using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Character
{
    Knight, Elf, Dwarf
}

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public Character currentCharacter;
}
