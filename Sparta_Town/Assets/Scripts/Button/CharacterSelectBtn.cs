using UnityEngine;

public class CharacterSelectBtn : MonoBehaviour
{
    public GameObject CharacterSelect;
    public GameObject Canvas;
    
    public void SelectCharacter()
    {
        CharacterSelect.SetActive(true);
        Canvas.SetActive(false);
    }
}