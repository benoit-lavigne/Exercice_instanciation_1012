using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InfosJoueur", menuName = "SO/NouveauJoueur")]
public class InfosJoueur : ScriptableObject
{

    public string nomJoueur;
    public int nbPoints;
    
    public int nbJaunes;
    public int nbRouges;
    public int nbPotions;


}
