using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BMI_Calculator_SOC_Application
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public int calculateBMI(int height, int weight)
        {
            return ((weight / height) * (height) * 703);
        }

        public string getHealthIndicator(int BMI)
        {
            if (BMI < 18)
            {
                return "You are underweight.";
            }
            else if (BMI >= 18 && BMI < 25)
            {
                return "Your weight is normal.";
            }
            else if (BMI >= 25 && BMI < 30)
            {
                return "You are pre-obese.";
            }
            else
            {
                return "You are obese.";
            }
        }


    }
}
