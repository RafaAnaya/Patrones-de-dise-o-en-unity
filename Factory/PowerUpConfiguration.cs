using System;
using System.Collections.Generic;
using UnityEngine;

namespace PowerUps{

    //Esta clase, es la logica que nos permite obtener una lista con los distintos powerApps que creemos en el editor.

    //Esta linea de codigo nos permite definir como crear un scriptableObject desde el menú de unity
    [CreateAssetMenu(menuName = "Factory/Power up configuration")]

    //Usamos la clase SriptableObject para ser capaces de crear GameObjects sin tener que crear un GameObject
    public class PowerUpConfiguration: ScriptableObject {

        //Este array lo usamos para almacenar los powerUps directamente desde el inspector, simplemente arrastrandolos.
        [UnityEngine.SerializeField] private PowerUp[] _powerUps;

        //Este diccionario lo usamos para almacenar el array powerUps y manejar más facilmente usando una estructura llave valor
        private Dictionary<string, PowerUp> _idToPowerUps;


         private void Awake() {
            _idToPowerUps = new Dictionary<string, PowerUp>();
            foreach (var PowerUp in _powerUps){
                _idToPowerUps.Add(PowerUp.Id, PowerUp);
            }
        } 

//Devuelve un powerUp en funcion del id que le pasan, si el powerUp no existe, devuelve un error.
    public PowerUp GetPowerUpPrefabById(string id){

        if(!_idToPowerUps.TryGetValue(id, out var PowerUp))
        {
            throw new Exception($"PowerUp with Id {id} does not exist");
        }

        return PowerUp;
    }  

    }
}