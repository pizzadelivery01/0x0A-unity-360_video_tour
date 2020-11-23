using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class CantinaButton : MonoBehaviour
{
    public GameObject LivingRoom;
	public GameObject Cantina;

    public void CantinaSwitch()
    {
		LivingRoom.SetActive(false);
		Cantina.SetActive(true);
    }
}