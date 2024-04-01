using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextManager : MonoBehaviour
{
    public static TextManager Instance;
    public TextMeshProUGUI DisplayText;
    public AlphabetTextDatas alphabetTextDatas;
    [SerializeField]
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    public void ChangeText(string alphabet)
    {
        DisplayText.text = alphabetTextDatas._data.Find(d => d._alphabet == alphabet)._alphabetText;
        animator.Play("Animate",-1,0f);
    }
}
