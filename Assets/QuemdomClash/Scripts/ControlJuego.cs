using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class ControlJuego : MonoBehaviour
{
    public void OnJugar()
    {
        Debug.Log("Ir a Jugar");
        MMSceneLoadingManager.LoadScene("Nvl 1");
    }
}
