using FishNet.Object;
using UnityEngine;

public class Footsteps : NetworkBehaviour
{
    [SerializeField]
    private PlayerStateMachine stateMachine;

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip[] footstepWalkingClips;

    [SerializeField]
    private AudioClip[] footstepRunningClips;

    public void FootR()
    {
        if (!IsOwner) return;
        audioSource
            .PlayOneShot(footstepWalkingClips[Random
                .Range(0, footstepWalkingClips.Length)]);
    }

    public void FootL()
    {
        if (!IsOwner) return;
        audioSource
            .PlayOneShot(footstepWalkingClips[Random
                .Range(0, footstepWalkingClips.Length)]);
    }
}
