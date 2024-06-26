using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ammo : MonoBehaviour
{
    public TextMeshProUGUI ammoText;
    private int _ammoAmount = 15;
    private int _ammoBoxAmount = 10;

    // Start is called before the first frame update
    void Start()
    {
        _ammoAmount = Random.Range(3, 7);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int GetAmmoAmount()
    {
        return _ammoAmount;
    }

    public void RemoveAmmo()
    {
        _ammoAmount -= 1;
        ammoText.text = "Ammo: " + _ammoAmount.ToString();
    }
}
