using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphabetSound : MonoBehaviour
{
    public string Alphabet;
    public AudioClip clip;
    private Animator animator;
    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }
    [ContextMenu("Play Audio")]
    private void OnMouseDown()
    {
        if(animator)
        {
            animator.Play("Moving");
        }
        AudioManager.Instance.PlayAudio(clip);
        TextManager.Instance.ChangeText(Alphabet);
    }

}
