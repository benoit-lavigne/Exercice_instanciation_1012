using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GestionAccueil : MonoBehaviour
{
    [SerializeField]      
    private InfosJoueur infosJoueur;

    [SerializeField]   
    private TMP_InputField nomJ;

    [SerializeField]                   
    private GestionScenes gestionaireScenes;


    void Start()
    { 
      nomJ.text = infosJoueur.nomJoueur;
 
    }


    public void ChangementNom(string nom){ 
        infosJoueur.nomJoueur = nom;
    }


    public void VerifieNoms()
    {   
        if (infosJoueur.nomJoueur != "")
        {
            gestionaireScenes.SceneSuivante();
        }
    }

}
