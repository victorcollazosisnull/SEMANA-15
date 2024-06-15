using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public string Escena;
    public void CambioEscena()
    {
        SceneManager.LoadScene(Escena);
    }
}
