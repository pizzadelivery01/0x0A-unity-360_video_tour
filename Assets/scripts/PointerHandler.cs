using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;
using Valve.VR;

public class PointerHandler : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;
	public GameObject LivingRoom;
	public GameObject Cantina;
	public GameObject Mezzanine;
	public GameObject Cube;
	public GameObject L2CanButton;
	public GameObject L2CubeButton;
	public GameObject Cube2CanButton;
	public GameObject Cube2LButton;
	public GameObject Cube2MezzButton;
	public GameObject Mezz2CubeButton;
	public GameObject Can2LButton;
	public GameObject Can2CubeButton;
	public GameObject LivInfo1ToolTip;
	public GameObject LivInfo2ToolTip;
	public GameObject CantinaInfo1ToolTip;
	public GameObject CubeInfo1ToolTip;
	public GameObject MezzInfo1ToolTip;
	public GameObject MezzInfo2ToolTip;
	public GameObject LivInfo1Button;
	public GameObject LivInfo2Button;
	public GameObject CantinaInfo1Button;
	public GameObject CubeInfo1Button;
	public GameObject MezzInfo1Button;
	public GameObject MezzInfo2Button;

	private float _fadeDuration = 1f;

    void Awake()
    {
        laserPointer.PointerIn += PointerInside;
        laserPointer.PointerOut += PointerOutside;
        laserPointer.PointerClick += PointerClick;
    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
		
        if (e.target.name == "L2CanButton" || e.target.name == "Cube2CanButton")
        {
			FadeToBlack();
         	Invoke("FadeFromBlack", (_fadeDuration * 3) );
			Invoke("SwaptoCantina", _fadeDuration);
			
        }
		else if (e.target.name == "L2CubeButton" || e.target.name == "Can2CubeButton" || e.target.name == "Mezz2CubeButton")
		{
			FadeToBlack();
         	Invoke("FadeFromBlack", _fadeDuration * 3);
			Invoke("SwaptoCube", _fadeDuration);
		}
		else if (e.target.name == "Can2LButton" || e.target.name == "Cube2LButton")
		{
			FadeToBlack();
			Invoke("FadeFromBlack", (_fadeDuration * 3) );
			Invoke("SwaptoLiving", _fadeDuration);
		}
		else if (e.target.name == "Cube2MezzButton")
		{
			FadeToBlack();
			Invoke("FadeFromBlack", (_fadeDuration * 3) );
			Invoke("SwaptoMezz", _fadeDuration);
		}
		else if ( e.target.name == "LivInfo1Button")
		{
			LivInfo1ToolTip.SetActive(!LivInfo1ToolTip.activeInHierarchy); 
		}
		else if ( e.target.name == "LivInfo2Button")
		{
			LivInfo2ToolTip.SetActive(!LivInfo2ToolTip.activeInHierarchy); 
		}
		else if ( e.target.name == "CantinaInfo1Button")
		{
			CantinaInfo1ToolTip.SetActive(!CantinaInfo1ToolTip.activeInHierarchy); 
		}
		else if ( e.target.name == "CubeInfo1Button")
		{
			CubeInfo1ToolTip.SetActive(!CubeInfo1ToolTip.activeInHierarchy); 
		}
		else if ( e.target.name == "MezzInfo1Button")
		{
			MezzInfo1ToolTip.SetActive(!MezzInfo1ToolTip.activeInHierarchy); 
		}
		else if ( e.target.name == "MezzInfo2Button")
		{
			MezzInfo2ToolTip.SetActive(!MezzInfo2ToolTip.activeInHierarchy); 
		}
    }

    public void PointerInside(object sender, PointerEventArgs e)
    {
        if (e.target.name == "L2CanButton")
        {
			L2CanButton.GetComponent<RectTransform>().anchorMax = new Vector2(0.6f, 0.6f);
        }
		else if (e.target.name == "L2CubeButton")
		{
			L2CubeButton.GetComponent<RectTransform>().anchorMax = new Vector2(0.6f, 0.6f);
		}
		else if (e.target.name == "Can2CubeButton")
		{
			Can2CubeButton.GetComponent<RectTransform>().anchorMax = new Vector2(0.6f, 0.6f);
		}
		else if (e.target.name == "Can2LButton")
		{
			Can2LButton.GetComponent<RectTransform>().anchorMax = new Vector2(0.6f, 0.6f);
		}
		else if (e.target.name == "Cube2LButton")
		{
			Cube2LButton.GetComponent<RectTransform>().anchorMax = new Vector2(0.6f, 0.6f);
		}
		else if (e.target.name == "Cube2CanButton")
		{
			Cube2CanButton.GetComponent<RectTransform>().anchorMax = new Vector2(0.6f, 0.6f);
		}
		else if (e.target.name == "Cube2MezzButton")
		{
			Cube2MezzButton.GetComponent<RectTransform>().anchorMax = new Vector2(0.6f, 0.6f);
		}
		else if (e.target.name == "Mezz2CubeButton")
		{
			Mezz2CubeButton.GetComponent<RectTransform>().anchorMax = new Vector2(0.6f, 0.6f);
		}
		else if (e.target.name == "LivInfo1Button")
        {
			LivInfo1Button.GetComponent<RectTransform>().anchorMax = new Vector2(0.6f, 0.6f);
        }
		else if (e.target.name == "LivInfo2Button")
        {
			LivInfo2Button.GetComponent<RectTransform>().anchorMax = new Vector2(0.6f, 0.6f);
        }
		else if (e.target.name == "CantinaInfo1Button")
        {
			CantinaInfo1Button.GetComponent<RectTransform>().anchorMax = new Vector2(0.6f, 0.6f);
        }
        else if (e.target.name == "CubeInfo1Button")
        {
			CubeInfo1Button.GetComponent<RectTransform>().anchorMax = new Vector2(0.6f, 0.6f);
        }
		else if (e.target.name == "MezzInfo1Button")
        {
			MezzInfo1Button.GetComponent<RectTransform>().anchorMax = new Vector2(0.6f, 0.6f);
        }
		else if (e.target.name == "MezzInfo2Button")
        {
			MezzInfo2Button.GetComponent<RectTransform>().anchorMax = new Vector2(0.6f, 0.6f);
        }

    }

    public void PointerOutside(object sender, PointerEventArgs e)
    {
        if (e.target.name == "L2CanButton")
        {
			L2CanButton.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
        }
		else if (e.target.name == "L2CubeButton")
		{
			L2CubeButton.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
		}
		else if (e.target.name == "Can2CubeButton")
		{
			Can2CubeButton.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
		}
		else if (e.target.name == "Can2LButton")
		{
			Can2LButton.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
		}
		else if (e.target.name == "Cube2LButton")
		{
			Cube2LButton.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
		}
		else if (e.target.name == "Cube2CanButton")
		{
			Cube2CanButton.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
		}
		else if (e.target.name == "Cube2MezzButton")
		{
			Cube2MezzButton.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
		}
		else if (e.target.name == "Mezz2CubeButton")
		{
			Mezz2CubeButton.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
		}
		else if (e.target.name == "LivInfo1Button")
        {
			LivInfo1Button.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
        }
		else if (e.target.name == "LivInfo2Button")
        {
			LivInfo2Button.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
        }
		else if (e.target.name == "CantinaInfo1Button")
        {
			CantinaInfo1Button.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
        }
        else if (e.target.name == "CubeInfo1Button")
        {
			CubeInfo1Button.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
        }
		else if (e.target.name == "MezzInfo1Button")
        {
			MezzInfo1Button.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
        }
		else if (e.target.name == "MezzInfo2Button")
        {
			MezzInfo2Button.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
        }
    }
	private void FadeToBlack()
     {
         SteamVR_Fade.Start(Color.black, _fadeDuration);
     }
     private void FadeFromBlack()
     {
         SteamVR_Fade.Start(Color.clear, _fadeDuration);
     }
	 private void SwaptoCantina()
	 {
		L2CanButton.GetComponent<RectTransform>().anchorMax = new Vector2(.5f, .5f);
		Cube2CanButton.GetComponent<RectTransform>().anchorMax = new Vector2(.5f, .5f);
        LivingRoom.SetActive(false);
		Cube.SetActive(false);
		Cantina.SetActive(true);
		CubeInfo1ToolTip.SetActive(false);
		LivInfo1ToolTip.SetActive(false);
		LivInfo2ToolTip.SetActive(false);

	 }
	 private void SwaptoCube()
	 {
		L2CubeButton.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
		Mezz2CubeButton.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
		Can2CubeButton.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
		Cantina.SetActive(false);
		Mezzanine.SetActive(false);
		LivingRoom.SetActive(false);
		Cube.SetActive(true);
		MezzInfo2ToolTip.SetActive(false);
		MezzInfo1ToolTip.SetActive(false);
		LivInfo1ToolTip.SetActive(false);
		LivInfo2ToolTip.SetActive(false);
		CantinaInfo1ToolTip.SetActive(false);
	 }
	 private void SwaptoLiving()
	 {
		Can2LButton.GetComponent<RectTransform>().anchorMax = new Vector2(.5f, .5f);
		Cube2LButton.GetComponent<RectTransform>().anchorMax = new Vector2(.5f, .5f);
		Cube.SetActive(false);
		Cantina.SetActive(false);
		LivingRoom.SetActive(true);
		CantinaInfo1ToolTip.SetActive(false);
		CubeInfo1ToolTip.SetActive(false);
	 }
	 private void SwaptoMezz()
	 {
		Cube2MezzButton.GetComponent<RectTransform>().anchorMax = new Vector2(.5f, .5f);
		Cube.SetActive(false);
		Mezzanine.SetActive(true);
		CubeInfo1ToolTip.SetActive(false);
	 }
}