using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Es un atributo de la clase que nos permite crear ScriptableObjects de tipo State desde la ventana de project
[CreateAssetMenu(menuName = "State")]
//Esta clase deriva ahora de los ScriptableObject
public class State : ScriptableObject
{  
    //Genero un campo de texto de tipo string, con un tamaño específico
    //[TextArea(,)] atributo de la variable que permite crear un cuadro de texto con la cantidad de líneas escalable
    //[SerializeField] atributo de la variable que permite que esta o una referencia siga siendo privada pero accesible desde el editor de Unity
    [TextArea(14, 10)] [SerializeField] string storyText;
    //Array de estados a los que podemos ir desde el estado actual
    [SerializeField] State[] nextStates;
    //Referencia al Sprite del Estado
    [SerializeField] Sprite storySprite;

    //Método que nos devuelve el contenido de la caja de texto del ScriptableObject
    public string GetStateStory()
    {
        return storyText;
    }

    //Método que nos devuelve los estados a los que podemos ir desde el estado actual
    public State[] GetNextStates()
    {
        return nextStates;
    }

    //Método que nos devuelve el contenido del Sprite del ScriptableObject
    public Sprite GetStateSprite()
    {
        return storySprite;
    }
}
