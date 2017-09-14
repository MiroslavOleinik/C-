using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Driver
    {
        private string m_name = null;
        private int m_driveExperience = 0;

        public Driver(string name, int driveExperience)
        {
            m_name = name;
            m_driveExperience = driveExperience;
        }

        public string GetName()
        {
            return m_name;
        }

        public int GetDriveExperience()
        {
            return m_driveExperience;
        }
    }
}
