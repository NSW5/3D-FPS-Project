using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Target : MonoBehaviour
{
    public TextMeshProUGUI targetText;
    private int _targetAmount;

    void Start()
    {
        this.gameObject.SetActive(true);
        _targetAmount = GameObject.FindGameObjectsWithTag("Floating Target").Length;
        targetText.text = "Targets:" + _targetAmount.ToString();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            //add points to the score
            if(this.gameObject.tag == "Floating Target")
            {
                //Destroy(this.gameObject);
                this.gameObject.SetActive(false);
            }
            //add grayscale to standing target later on
        }
    }
}
