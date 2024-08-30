using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{

    [SerializeField]
    AudioSource audioSourceSFX;

    [SerializeField]
    AudioClip _1H_Melee_Attack_Slice_Audio;

    [SerializeField]
    AudioSource runOnGlass_Audio;

    [SerializeField]
    VariableJoystick variableJoystick;
    private float joystickThreshold = 0.1f;

    private void Update()
    {
        HandleMovementAudio();
    }

    void Play_1H_Melee_Attack_Slide_Audio() 
    {
        this.audioSourceSFX.PlayOneShot(_1H_Melee_Attack_Slice_Audio);
    }

    void HandleMovementAudio()
    {
        // Assuming you're using the standard horizontal and vertical axes for joystick movement
        float horizontalInput = variableJoystick.Horizontal;
        float verticalInput = variableJoystick.Vertical;

        // Check if the joystick is being moved
        if (Mathf.Abs(horizontalInput) > joystickThreshold || Mathf.Abs(verticalInput) > joystickThreshold)
        {
            if (!runOnGlass_Audio.isPlaying)
            {
                runOnGlass_Audio.Play();
            }
        }
        else
        {
            if (runOnGlass_Audio.isPlaying)
            {
                runOnGlass_Audio.Stop();
            }
        }
    }
}
