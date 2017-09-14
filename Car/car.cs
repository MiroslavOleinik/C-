using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Car
    {
        private string m_model = null;
        private int m_curentSpeed = 0;
        private Driver m_driver;

        public Car(string model)
        {
            this.m_model = model;
        }

        public string GetModel()
        {
            return m_model;
        }

        public void Acceleration()
        {
            m_curentSpeed += 10;
        }
    }
}
