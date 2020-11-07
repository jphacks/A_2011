﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeTimerRun : MonoBehaviour
{
    GameObject TimerObject;
    TimerScript timer;
	public AudioClip beep;
 	AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.Find("TimerObject").GetComponent<TimerScript>();
		audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer.timerState != 0){
			if ( timer.isActivePhase ){
				if(timer.activeTimeLeft <= 0){
					//Action of phase changing is written in this section
					audioSource.PlayOneShot(beep);
					timer.isActivePhase = false;
					timer.activeTimeLeft = timer.time1;
					timer.activeTimeText.text = timer.activeTimeLeft.ToString("00");
					goto campaign;
				}
				if(timer.timerState == 1){
					if(Time.timeScale == 0){
						Time.timeScale = 1.0f;
					}
					timer.activeTimeLeft -= Time.deltaTime; 
					timer.activeTimeText.text = timer.activeTimeLeft.ToString("00");
				}
				if(timer.timerState == 2){
					Time.timeScale = 0;
				}
				timer.activeTimeText.text = timer.activeTimeLeft.ToString("00");
			}
			if ( !timer.isActivePhase ){
				if(timer.intervalTimeLeft <= 0){
					//Action of phase changing is written in this section
					audioSource.PlayOneShot(beep);
					timer.isActivePhase = true;
					--timer.numberOfSetsLeft;
					timer.intervalTimeLeft = timer.time2;
					timer.setsNumberText.text = timer.numberOfSetsLeft.ToString("00");
					timer.intervalTimeText.text = timer.intervalTimeLeft.ToString("00");
					goto campaign;
				}
				if(timer.timerState == 1){
					if(Time.timeScale == 0){
						Time.timeScale = 1.0f;
					}
					timer.intervalTimeLeft -= Time.deltaTime; 
					timer.intervalTimeText.text = timer.intervalTimeLeft.ToString("00");
				}
				if(timer.timerState == 2){
					Time.timeScale = 0;
				}
				timer.intervalTimeText.text = timer.intervalTimeLeft.ToString("00");
			}
		}

campaign:;
		if(timer.numberOfSetsLeft <= 0){
			//Finishing acctions should be written here
			timer.cease();
		}
    }
}
