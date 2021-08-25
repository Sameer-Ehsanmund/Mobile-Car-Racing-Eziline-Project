using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Vehicles.Car;
using SimpleInputNamespace;
using UnityEngine.UI;


namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use

        private int input;

        public GameObject CarControl;

        public GameObject forwardBut;

        

        public void Start()
        {
            CarControl.GetComponent<CarController>().enabled = true;

            //Forward FB = forwardBut.GetComponent<Forward>();
            //forwardBut = GameObject.Find("forwardMovingButton").GetComponent<forwardButton>();

            
        }

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        public void FixedUpdate()
        {
            // pass the input to the car!
            float h = SimpleInput.GetAxis("Horizontal");
            float v = SimpleInput.GetAxis("Vertical");
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h, input, input, 0f);
#endif
        }

        public void forward()
        {

            input = 1;
        }

        public void backward()
        {

            input = -1;
        }

        public void pointerUP()
        {

            input = 0;
        }
    }
}
