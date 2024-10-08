using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerOne : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Text;

    public string Name = "JAH-REK";
    public int Age = 77;
    public string Race = "Black Chinese";
    public int PhysicalDamage = 36;
    public int Armor = 150;
    public int MagicDamage = 70;
    public int MagicResistance = 69;
    public int Speed = 60;

    public void DisplayPlayerOne()
    {
        Text.text = "Name: " + Name + "\nAge: " + Age + "\nRace: " + Race + "\nPhysical Damage: " + PhysicalDamage + "\nArmor: " + Armor + "\nMagic Damage:" + MagicDamage + "\nMagic Resistance: " + MagicResistance + "\nSpeed: " + Speed;
    }
}