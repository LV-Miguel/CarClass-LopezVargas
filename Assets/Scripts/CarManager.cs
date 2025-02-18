//////////////////////////////////////////////
//Assignment/Lab/Project: Car Class
//Name: Miguel Lopez Vargas
//Section: SGD.213.0021
//Instructor: Professor Locklear
//Date: 02/17/2025
/////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Security.Cryptography.X509Certificates;
using UnityEngine.UIElements;

public class CarManager : MonoBehaviour
{
    private Car carInstance;

    public InputField carMakeNameInput;
    public InputField carYearInput;
    public TMP_Text carMakeText;
    public TMP_Text carYearText;
    public TMP_Text SpeedText;

    private bool carMakeAccepted = false;
    private bool carYearAccepted = false;

    public GameObject carPanel;
    public GameObject carInfoPanel;


    void Start()
    {
        carInstance = new Car();
        carPanel.SetActive(false);
        carInfoPanel.SetActive(true);
        
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            carInstance.SpeedUp();
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            carInstance.SlowDown();
        }

    }

    public void OnClickCarMake()
    {
        if (carMakeNameInput.text != null)
        {
            carInstance.carMake = carMakeNameInput.text;
            carMakeText.text = carInstance.carMake;
            carMakeAccepted = true;
        }
    }

    public void OnClickCarYear()
    {
        if (carYearInput.text != null)
        {
            carInstance.yearCarMade = int.Parse(carYearInput.text);
            carMakeText.text = carInstance.yearCarMade.ToString();
            carYearAccepted = true;
        }
    }

    private void CheckForCarMakeAndYear()
    {
        if (carYearAccepted == true && carMakeAccepted == true)
        {
            carPanel.SetActive(true);

        }
    }

    

}
