using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TypeDictionary : MonoBehaviour
{
    // Create a dictionary to store type effectiveness
    public Dictionary<string, int> typeEffectiveness = new Dictionary<string, int>();

    private void Start()
    {
        //Normal
        typeEffectiveness.Add("Normal-Rock", 5);
        typeEffectiveness.Add("Normal-Ghost", 0);
        typeEffectiveness.Add("Normal-Steel", 0);
        //Fire
        typeEffectiveness.Add("Fire-Grass", 20);
        typeEffectiveness.Add("Fire-Water", 5);
        typeEffectiveness.Add("Fire-Fire", 5);
        typeEffectiveness.Add("Fire-Ice", 20);
        typeEffectiveness.Add("Fire-Bug", 20);
        typeEffectiveness.Add("Fire-Steel", 20);
        typeEffectiveness.Add("Fire-Rock", 5);
        typeEffectiveness.Add("Fire-Dragon", 5);
        //Water
        typeEffectiveness.Add("Water-Fire", 20);
        typeEffectiveness.Add("Water-Water", 5);
        typeEffectiveness.Add("Water-Grass", 5);
        typeEffectiveness.Add("Water-Ground", 20);
        typeEffectiveness.Add("Water-Rock", 20);
        typeEffectiveness.Add("Water-Dragon", 5);
        //Grass
        typeEffectiveness.Add("Grass-Fire", 5);
        typeEffectiveness.Add("Grass-Water", 20);
        typeEffectiveness.Add("Grass-Grass", 5);
        typeEffectiveness.Add("Grass-Poison", 5);
        typeEffectiveness.Add("Grass-Ground", 20);
        typeEffectiveness.Add("Grass-Flying", 5);
        typeEffectiveness.Add("Grass-Bug", 5);
        typeEffectiveness.Add("Grass-Rock", 20);
        typeEffectiveness.Add("Grass-Dragon", 5);
        typeEffectiveness.Add("Grass-Steel", 5);
        //Electric
        typeEffectiveness.Add("Electric-Water", 20);
        typeEffectiveness.Add("Electric-Grass", 5);
        typeEffectiveness.Add("Electric-Electric", 5);
        typeEffectiveness.Add("Electric-Ground", 0);
        typeEffectiveness.Add("Electric-Flying", 20);
        typeEffectiveness.Add("Electric-Dragon", 5);
        //Ice
        typeEffectiveness.Add("Ice-Fire", 5);
        typeEffectiveness.Add("Ice-Water", 5);
        typeEffectiveness.Add("Ice-Grass", 20);
        typeEffectiveness.Add("Ice-Ice", 5);
        typeEffectiveness.Add("Ice-Ground", 20);
        typeEffectiveness.Add("Ice-Flying", 20);
        typeEffectiveness.Add("Ice-Dragon", 20);
        typeEffectiveness.Add("Ice-Steel", 5);
        //Fighting
        typeEffectiveness.Add("Fighting-Normal", 20);
        typeEffectiveness.Add("Fighting-Ice", 20);
        typeEffectiveness.Add("Fighting-Poison", 5);
        typeEffectiveness.Add("Fighting-Flying", 5);
        typeEffectiveness.Add("Fighting-Psychic", 5);
        typeEffectiveness.Add("Fighting-Bug", 5);
        typeEffectiveness.Add("Fighting-Rock", 20);
        typeEffectiveness.Add("Fighting-Ghost", 0);
        typeEffectiveness.Add("Fighting-Dark", 20);
        typeEffectiveness.Add("Fighting-Steel", 20);
        typeEffectiveness.Add("Fighting-Fairy", 5);
        //Poison
        typeEffectiveness.Add("Poison-Grass", 20);
        typeEffectiveness.Add("Poison-Poison", 5);
        typeEffectiveness.Add("Poison-Ground", 5);
        typeEffectiveness.Add("Poison-Rock", 5);
        typeEffectiveness.Add("Poison-Ghost", 5);
        typeEffectiveness.Add("Poison-Steel", 0);
        typeEffectiveness.Add("Poison-Fairy", 20);
        //Ground
        typeEffectiveness.Add("Ground-Fire", 20);
        typeEffectiveness.Add("Ground-Grass", 5);
        typeEffectiveness.Add("Ground-Electric", 20);
        typeEffectiveness.Add("Ground-Poison", 20);
        typeEffectiveness.Add("Ground-Flying", 0);
        typeEffectiveness.Add("Ground-Bug", 5);
        typeEffectiveness.Add("Ground-Rock", 20);
        typeEffectiveness.Add("Ground-Steel", 20);
        //Flying
        typeEffectiveness.Add("Flying-Grass", 20);
        typeEffectiveness.Add("Flying-Electric", 5);
        typeEffectiveness.Add("Flying-Fighting", 20);
        typeEffectiveness.Add("Flying-Bug", 20);
        typeEffectiveness.Add("Flying-Rock", 5);
        typeEffectiveness.Add("Flying-Steel", 5);
        //Psychic
        typeEffectiveness.Add("Psychic-Fighting", 20);
        typeEffectiveness.Add("Psychic-Poison", 20);
        typeEffectiveness.Add("Psychic-Psychic", 5);
        typeEffectiveness.Add("Psychic-Dark", 0);
        typeEffectiveness.Add("Psychic-Steel", 5);
        //Bug
        typeEffectiveness.Add("Bug-Fire", 5);
        typeEffectiveness.Add("Bug-Grass", 20);
        typeEffectiveness.Add("Bug-Fighting", 5);
        typeEffectiveness.Add("Bug-Poison", 5);
        typeEffectiveness.Add("Bug-Flying", 5);
        typeEffectiveness.Add("Bug-Psychic", 20);
        typeEffectiveness.Add("Bug-Ghost", 5);
        typeEffectiveness.Add("Bug-Dark", 20);
        typeEffectiveness.Add("Bug-Steel", 5);
        typeEffectiveness.Add("Bug-Fairy", 5);
        //Rock
        typeEffectiveness.Add("Rock-Fire", 20);
        typeEffectiveness.Add("Rock-Ice", 20);
        typeEffectiveness.Add("Rock-Fighting", 5);
        typeEffectiveness.Add("Rock-Ground", 5);
        typeEffectiveness.Add("Rock-Flying", 20);
        typeEffectiveness.Add("Rock-Bug", 20);
        typeEffectiveness.Add("Rock-Steel", 5);
        //Ghost
        typeEffectiveness.Add("Ghost-Normal", 0);
        typeEffectiveness.Add("Ghost-Psychic", 20);
        typeEffectiveness.Add("Ghost-Ghost", 20);
        typeEffectiveness.Add("Ghost-Dark", 5);
        //Dragon
        typeEffectiveness.Add("Dragon-Dragon", 20);
        typeEffectiveness.Add("Dragon-Steel", 5);
        typeEffectiveness.Add("Dragon-Fairy", 0);
        //Dark
        typeEffectiveness.Add("Dark-Fighting", 5);
        typeEffectiveness.Add("Dark-Psychic", 20);
        typeEffectiveness.Add("Dark-Ghost", 20);
        typeEffectiveness.Add("Dark-Dark", 5);
        typeEffectiveness.Add("Dark-Fairy", 5);
        //Steel
        typeEffectiveness.Add("Steel-Fire", 5);
        typeEffectiveness.Add("Steel-Water", 5);
        typeEffectiveness.Add("Steel-Electric", 5);
        typeEffectiveness.Add("Steel-Ice", 20);
        typeEffectiveness.Add("Steel-Rock", 20);
        typeEffectiveness.Add("Steel-Steel", 5);
        typeEffectiveness.Add("Steel-Fairy", 20);
        //Fairy
        typeEffectiveness.Add("Fairy-Fire", 5);
        typeEffectiveness.Add("Fairy-Fighting", 20);
        typeEffectiveness.Add("Fairy-Poison", 5);
        typeEffectiveness.Add("Fairy-Dragon", 20);
        typeEffectiveness.Add("Fairy-Dark", 20);
        typeEffectiveness.Add("Fairy-Steel", 5);
    }
}
