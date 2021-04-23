using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleurCamera : MonoBehaviour
{
	public GameObject player; //player représente le Joueur qui est la balle
    private Vector3 offset; 
    void Start () {
         offset = transform.position - player.transform.position;
//on commence par récupérer la distance initiale entre la Caméra et le Joueur
    }
    void LateUpdate () {
         transform.position = player.transform.position + offset;
//La Caméra va garder toujours la même distance par rapport au Joueur
    }


}
