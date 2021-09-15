using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Esta clase es la encargada de consumir el factory de powerUps

namespace PowerUps{

    public class PowerUpSpawner: MonoBehaviour
    {


        //Esta clase recibe una instancia de un objeto del tipo PowerUpConfiguration y otra de tipo PowerUpFactory.
        //Serializamos _powerUpConfiguration para hacer mas sencillo el cambiar la configuración de la fabrica
        [SerializeField] private PowerUpConfiguration _powerUpConfiguration;
        private PowerUpFactory _powerFactory; 

        private void Awake() {
            _powerFactory = new PowerUpFactory(Instantiate(_powerUpConfiguration));
        }

        void Update()
        {
            if(Input.GetKeyDown("a")){
                _powerFactory.Create("speed");
            }
            else if(Input.GetKeyDown("w")){
                _powerFactory.Create("strong");
            }
        }
    }
}
