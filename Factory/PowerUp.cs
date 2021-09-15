using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Esta clase es la clase abstracta de la que heredan todos los power apps, solo se encarga de recibir un id con el nombre del powerApp

namespace PowerUps
{
    public abstract class PowerUp : MonoBehaviour
    {
        //Creamos una variable Id y la serializamos para que, el tipo de power app que queremos instanciar pueda ser definido simplemente arrastrando el powerApp desde el inspector.

        [SerializeField] private string _id;
        public string Id => _id;
    }
}

