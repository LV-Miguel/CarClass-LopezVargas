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
    private int _yearCarMade;
    private string _carMake;
    private int _maxSpeed = 100;
    private int _currentSpeed = 0;

    public int yearCarMade
    {
        get
        {
            return _yearCarMade;
        }

        set
        {
            if (_yearCarMade >= 1886 && _yearCarMade <= 2025)
            {
                _yearCarMade = value;
            }
        }
    }

    public string carMake
    {
        get
        {
            return _carMake;
        }

        set
        {
            if ( _carMake != null)
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
        if (_currentSpeed < _maxSpeed)
        {
            _currentSpeed = _currentSpeed + 1;
            Debug.Log(_currentSpeed);
        }
    }

    public void SlowDown()
    {
        if (_currentSpeed > 0)
        {
            _currentSpeed = _currentSpeed - 1;
            Debug.Log(_currentSpeed);
        }
    }


}
