using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    [SerializeField] Image[] healtharray;
    [SerializeField] Sprite heartFull;
    [SerializeField] Sprite heartEmpty;

    private void Awake ()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void UpdateHealthDisplay()
    {
        for(int i = 0; i < healtharray.Length; i++)
        {
            if (i < PlayerHealthController.instance.currentHealth)
                healtharray[i].sprite = heartFull;
            else
                healtharray[i].sprite = heartEmpty;
        }
    }
}
