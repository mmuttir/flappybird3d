using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowRedScreen : MonoBehaviour
{
    static Image imge;
    // Start is called before the first frame update
    private void Start()
    {
        imge = GetComponent<Image>();
    }
    public static void Show()
    {
        var tempColor = imge.color;
        tempColor.a = .3f;
        imge.color = tempColor;
        ShowWastedText.Show();
    }
}
