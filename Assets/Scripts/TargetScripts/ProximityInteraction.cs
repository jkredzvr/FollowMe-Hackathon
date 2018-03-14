﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityInteraction : MonoBehaviour, ITargetInteraction {
    private BoxCollider boxCol;
    public Renderer[] renderers;
    public SequenceState seqState;
    public AudioManagerSingleton audioManager;
    public bool hasPlayed;

    public bool playsAnimation;
    public string animtransitionname;
    // Use this for initialization
    void Start () {
        hasPlayed = false;
        boxCol = GetComponent<BoxCollider>();
        renderers = GetComponentsInChildren<Renderer>();
        audioManager = AudioManagerSingleton.Instance;
	}

    private void OnTriggerEnter(Collider other) {
        Debug.Log("Triggered");
        if (!hasPlayed) {
            hasPlayed = true;
            Success();
        }
    }

    public void PlayAudio() {
        //audioManager.SetClip(seqState.successClip);
        Debug.Log("playing audio");
        AudioManager.Instance.PlayClipAt(seqState.successClip, this.transform.position);
    }

    public void RenderSuccessColor() {
        foreach (Renderer renderer in renderers) {
            renderer.material.color = Color.green;
        }
    }

    public void MessageGameController() {
        Debug.Log("Tell GM trigger entered");
    }

    public void Success() {
        MessageGameController();
        RenderSuccessColor();
        PlayAudio();

        if (playsAnimation) {
            PlayAnimation();
        }
    }


    public void PlayAnimation() {
        Debug.Log("playing:" + animtransitionname);
        MasterAnimScript.Instance.PlayClip(animtransitionname);
    }
}
