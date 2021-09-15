using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace PowerUps{

//La clase factory se caracterza por devolver una instancia de un objeto de tipo de la clase padre del objeto que vamos a crear, en este caso powerUp
public class PowerUpFactory
{
   
   private readonly PowerUpConfiguration _powerUpConfiguration;

   public PowerUpFactory(PowerUpConfiguration powerUpConfiguration){
       _powerUpConfiguration = powerUpConfiguration;
   }

  //Este metodo devuelve una instancia de la clase PowerUp del que heredan los distintos tipos de powerUp, en lugar de devolver una instancia del powerUp en concreto, esto es posible gracias a que podemos usar una instancia del objeto padre, para remplazar al hijo. Debemos tomar en cuenta que solo se podrá acceder a los métodos del objeto padre, es decir no podremos acceder a metodos no definidos declarados en la clase abstracta.
  
    public PowerUp Create(string id)
    {
      var powerUp = _powerUpConfiguration.GetPowerUpPrefabById(id);

        return Object.Instantiate(powerUp);
    }
}

}