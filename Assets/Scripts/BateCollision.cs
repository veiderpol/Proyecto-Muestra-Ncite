using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BateCollision : MonoBehaviour{
    private ObjectPooler objectPooler;
    private PlayerController playerController;
    GameObject objPooler, objPlayer;
    void Start(){
       objPooler = GameObject.Find("ObjectPooler");
       objectPooler = objPooler.GetComponent<ObjectPooler>();

       objPlayer = GameObject.Find("CoolDude1");
       playerController = objPlayer.GetComponent<PlayerController>();
       
    }
   void OnTriggerEnter(Collider col){
       if(col.gameObject.CompareTag("RespoM")){
           objectPooler.puntuaje += 100 * (int)(playerController.sliderValue);
       }
       if(col.gameObject.CompareTag("Respo")){
           objectPooler.ControlVidas();
       }
   }
}
