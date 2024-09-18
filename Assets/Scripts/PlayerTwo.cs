using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerTwo : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Text;


    public string Name = "ANDREI";
    public int Age = 69;
    public string Race = "lightskin black";
    public int PhysicalDamage = 50;
    public int Armor = 160;
    public int MagicDamage = 43;
    public int MagicResistance = 50;
    public float Speed = 80;

    public void DisplayPlayerTwo()
    {
        Text.text = "Name: " + Name + "\nAge: " + Age + "\nRace: " + Race + "\nPhysical Damage: " + PhysicalDamage + "\nArmor: " + Armor + "\nMagic Damage:" + MagicDamage + "\nMagic Resistance: " + MagicResistance + "\nSpeed: " + Speed;
    }
}
