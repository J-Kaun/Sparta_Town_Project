using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Timeline;

namespace Assets.Scripts.Manager.Controller
{
    public class PlayerController : MonoBehaviour
    {
        public Transform Knight_Pf;
        public Transform Elf_Pf;
        public Transform Dwarf_Pf;

        public float followSpeed = 4f;

        private void Update()
        {
            if (Knight_Pf != null)
            {
                Vector2 direction = (Knight_Pf.position - transform.position).normalized;
                Vector3 movement = direction * followSpeed * Time.deltaTime;
                transform.position += movement;
            }
            else if (Elf_Pf != null)
            {
                Vector2 direction = (Elf_Pf.position - transform.position).normalized;
                Vector3 movement = direction * followSpeed * Time.deltaTime;
                transform.position += movement;
            }
            else if (Dwarf_Pf != null)
            {
                Vector2 direction = (Dwarf_Pf.position - transform.position).normalized;
                Vector3 movement = direction * followSpeed * Time.deltaTime;
                transform.position += movement;
            }
        }
    }
}