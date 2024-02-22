using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private bool raceFinished = false;  // Variable para verificar si la carrera ha terminado
    private float finishTime;           // Variable para almacenar el tiempo de finalizaci�n

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car") && !raceFinished)
        {
            raceFinished = true;  // Marcar la carrera como finalizada para evitar m�ltiples ejecuciones

            // Detener el contador (Timer)
            Timer timerScript = FindObjectOfType<Timer>();
            if (timerScript != null)
            {
                timerScript.StopTimer();
                finishTime = timerScript.GetElapsedTime();  // Obtener el tiempo actual del contador
            }

            Debug.Log("�L�nea de meta a tiempo! Tiempo final: " + finishTime);
        }
    }
}

