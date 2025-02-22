﻿using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "Data/Charater")]
public class Character : ScriptableObject {

    /* 
     * Data for characters settings.
     */

    public new string Name;
    public int Cost;
    public Sprite Sprite;
    public bool Availability;

}
