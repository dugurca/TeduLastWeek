using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

namespace Assets._Project.Scripts
{
    public class ShowCarSpeed : MonoBehaviour
    {
        public CarController PlayerCar;
        public Text SpeedText;
	
        void Update ()
        {
            int speed = (int) PlayerCar.CurrentSpeed;
            SpeedText.text = "Speed: " + speed + "\n" + "km/h";
        }
    }
}
