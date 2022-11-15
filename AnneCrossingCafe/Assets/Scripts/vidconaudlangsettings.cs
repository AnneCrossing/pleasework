using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class vidconaudlangsettings : MonoBehaviour {
	public AudioMixer audiomixer;

	public void graphicsettings(int qualitylevel){
		QualitySettings.SetQualityLevel(qualitylevel);

	}
	public void volume(float vol) {
		audiomixer.SetFloat("volparameter", vol); //this is the name of the parameter i made in the audio window, so i'm linking it with the vol variable so it can adjust on the slider

	}

	}
