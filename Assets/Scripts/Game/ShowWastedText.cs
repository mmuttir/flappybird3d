using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowWastedText : MonoBehaviour
{
    private static TMP_Text wasted;
    // Start is called before the first frame update
    void Start()
    {
        wasted = GetComponent<TMP_Text>();
    }
    public static void Show()
    {
        wasted.enabled = true;
    }
}
