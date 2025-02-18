//////////////////////////////////////////////
//Assignment/Lab/Project: Car Class
//Name: Miguel Lopez Vargas
//Section: SGD.213.0021
//Instructor: Professor Locklear
//Date: 02/17/2025
/////////////////////////////////////////////
using UnityEngine;

public class Car
{
    private int _yearCarMade; //private fields
    private string _carMake;
    private int _maxSpeed = 100;
    private int _currentSpeed = 0;

    public int yearCarMade //get and set for the car year made
    {
        get
        {
            return _yearCarMade;
        }

        set
        { 
            if (value >= 1886 && value <= 2025) //checks if the value is int he range set
            {
                _yearCarMade = value;
            }
        }
    }

    public string carMake //get and set for the car model
    {
        get
        {
            return _carMake;
        }

        set
        {
            
            if ( value != null)
            {
                _carMake = value;
            }
        }
    }
    public int currentSpeed
    {
        get
        {
            return _currentSpeed;
        }
    }

    public void SpeedUp()
    {
        if (_currentSpeed < _maxSpeed) //sets the speed to make sure the car doesnt go over 100
        {
            _currentSpeed = _currentSpeed + 1; //increases speed
            
        }
    }

    public void SlowDown()
    {
        if (_currentSpeed > 0) //sets the speed to make sure the car doesnt go under 0
        {
            _currentSpeed = _currentSpeed - 1; //decresses speed
            
        }
    }


}
