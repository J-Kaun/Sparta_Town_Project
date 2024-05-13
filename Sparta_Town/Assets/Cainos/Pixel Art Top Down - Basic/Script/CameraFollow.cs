using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    
    //let camera follow target
    public class CameraFollow : MonoBehaviour
    {
        public Transform target;
        public float lerpSpeed = 1.0f;

        private Vector3 offset;

        private Vector3 targetPos;

        private void Start()
        {
            SetTargetByCharacter(GameManager.Instance.selectedCharacter);
        }

        private void Update()
        {
            if (target == null) return;

            targetPos = target.position + offset;
            transform.position = Vector3.Lerp(transform.position, targetPos, lerpSpeed * Time.deltaTime);
        }

        public void SetTargetByCharacter(Character character)
        {
            switch (GameManager.Instance.selectedCharacter)
            {
                case Character.Knight:
                    target = GameObject.Find("Knight_Pf").transform;
                    break;
                case Character.Elf:
                    target = GameObject.Find("Elf_Pf").transform;
                    break;
                case Character.Dwarf:
                    target = GameObject.Find("Dwarf_Pf").transform;
                    break;
                default:
                    target = null;
                    break;
            }

            if (target == null) return;

            offset = transform.position - target.position;
        }

    }
}
