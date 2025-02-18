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

    public TMP_InputField carMakeNameInput; //inputfield for text to be entered
    public TMP_InputField carYearInput;
    public TMP_Text carMakeText; //texts for the car make, year, and speed
    public TMP_Text carYearText;
    public TMP_Text speedText;

    private bool carMakeAccepted = false; //set the requirements to false
    private bool carYearAccepted = false;

    private int carYearHolder; //variables for the year and make to hold for a moment
    private string carMakeHolder;
    public GameObject carPanel; //gameobjects for the panels
    public GameObject carInfoPanel;


    void Start()
    {
        carInstance = new Car(); //instance for the cars class script
        carPanel.SetActive(false); //setting the panels to false
        carInfoPanel.SetActive(true); //infor for the player to input info for the car
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) //if sets for the up arrow and down arrow to go up in speed or down in speed
        {
            carInstance.SpeedUp(); //calls method
            speedText.text = carInstance.currentSpeed.ToString(); //sets the text for speed
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            carInstance.SlowDown();
            speedText.text = carInstance.currentSpeed.ToString();
        }

    }

    public void OnClickCarMake() //onclick, method so the player can enter the info for the model
    {
        if (carMakeNameInput.text != null) //if statement to make sure there is something in the input
        {
            carInstance.carMake = carMakeNameInput.text; //sets the input in the carmake var 
            carMakeAccepted = true; //sets to true
            CheckForCarMakeAndYear(); //method called for the code to check if they will set the car
        }
    }

    public void OnClickCarYear() //same as the last onclick method but for the year
    {
        if (carYearInput.text != null && int.Parse(carYearInput.text) >= 1886 && int.Parse(carYearInput.text) <= 2025) //checks the years and if empty
        {
            carInstance.yearCarMade = int.Parse(carYearInput.text); //coverts the text into int for the var in car
            carYearAccepted = true;
            CheckForCarMakeAndYear();
        }
    }

    private void CheckForCarMakeAndYear()
    {
        if (carYearAccepted == true && carMakeAccepted == true) //checks if both inputs are valid
        {
            carPanel.SetActive(true); //sets the panel to true to appear
            carMakeText.text = carInstance.carMake; //sets the make text to the model from the car
            carYearText.text = carInstance.yearCarMade.ToString(); //sets the make text to the year from the car
        }
    }

    

}
