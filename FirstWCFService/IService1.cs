﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FirstWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        double add(double num1,double num2);
        [OperationContract]
        double Sub(double num1, double num2);
        [OperationContract]
        double Multipli(double num1, double num2);
        [OperationContract]
        double Divide(double num1, double num2);
    }

    
}
