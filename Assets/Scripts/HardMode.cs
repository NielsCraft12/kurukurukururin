using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HardMode : MonoBehaviour
{
    [SerializeField] private Toggle hardModeToggle;
    public bool hardMode = false;
    // Start is called before the first frame update
    void Start()
    {
      int hardmode =  PlayerPrefs.GetInt("hardmode");

        if (hardmode == 1)
        {
            hardMode = true;
        }

        hardModeToggle.isOn = hardMode;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HardModeToggle(bool value)
    {
        if (value == true)
        {
            PlayerPrefs.SetInt("hardmode", 1);
            hardMode = true;
        }
        else
        {
            PlayerPrefs.SetInt("hardmode", 0);
            hardMode = false;
        }
    
    }
}
