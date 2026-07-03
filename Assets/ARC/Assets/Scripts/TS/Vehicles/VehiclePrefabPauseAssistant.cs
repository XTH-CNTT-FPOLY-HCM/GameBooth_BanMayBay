using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;

namespace TS.Generics
{
    public class VehiclePrefabPauseAssistant : MonoBehaviour
    {
        public Rigidbody    vRb;
        public bool         remKinematicState;
        public Vector3      remVelocity;

       public bool PauseVehicle()
        {
            //Debug.Log("Pause Vehicle");
            return true;
        }

        public bool UnPauseVehicle()
        {
            //Debug.Log("UnPause Vehicle");
            return true;
        }



        public bool PauseMovement()
        {
            remKinematicState = vRb.isKinematic;
            remVelocity = vRb.linearVelocity;
            vRb.isKinematic = true;
            vRb.linearVelocity = Vector3.zero;
            
            return true;
        }

        public bool UnpauseMovement()
        {
            vRb.isKinematic = remKinematicState;
            vRb.linearVelocity = remVelocity;
            return true;
        }
    }
}