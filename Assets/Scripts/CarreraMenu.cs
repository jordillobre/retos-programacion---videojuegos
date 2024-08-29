using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// using TMPro;
using UnityEngine.UI;


public class CarreraMenu : MonoBehaviour{

    public GameObject opciones;
    public GameObject InstruccionesCarrera;
    public GameObject EnunciadoCarrera;

    public Text textoEnunciado;

    public void PlayCarrera(){

    }

    public void ShowStatementRace(){
        opciones.SetActive(false);
        EnunciadoCarrera.SetActive(true);

        string enunciado = "Crea un programa que simule la competición de dos coches en una pista.\n" +
                           "Los dos coches estarán representados por 🚙 y 🚗. Y la meta por 🏁.\n" +
                           "Cada pista tendrá entre 1 y 3 árboles 🌲 colocados de forma aleatoria.\n" +
                           "Las dos pistas tendrán una longitud configurable de guiones bajos \"_\".\n" +
                           "Los coches comenzarán en la parte derecha de las pistas. Ejemplo:\n" +
                           "    🏁____🌲_____🚙\n" +
                           "    🏁_🌲____🌲___🚗\n\n" +
                           "El juego se desarrolla por turnos de forma automática, y cada segundo se realiza una acción sobre los coches (moviéndose a la vez), hasta que uno de ellos (o los dos a la vez) llega a la meta.\n" +
                           "Acciones:\n" +
                           "Avanzar entre 1 a 3 posiciones hacia la meta.\n" +
                           "Si al avanzar, el coche finaliza en la posición de un árbol, se muestra 💥 y no avanza durante un turno.\n" +
                           "Cada turno se imprimen las pistas y sus elementos.\n" +
                           "Cuando la carrera finalice, se muestra el coche ganador o el empate.";

        textoEnunciado.text = enunciado;              
    }

    public void ShowRaceInstructions(){

    }

    public void RetunMain(){
        SceneManager.LoadScene("MainMenu");
    }

    public void Start(){
        opciones.SetActive(true);
        InstruccionesCarrera.SetActive(false);
        EnunciadoCarrera.SetActive(false);
    }

    public void CloseStatement(){
        opciones.SetActive(true);
        EnunciadoCarrera.SetActive(false);
    }
   
}
