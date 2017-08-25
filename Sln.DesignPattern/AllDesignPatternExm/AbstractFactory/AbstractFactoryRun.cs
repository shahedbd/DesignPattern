using AllDesignPatternExm.AbstractFactory.Phones;
using System;

namespace AllDesignPatternExm.AbstractFactory
{
    public static class AbstractFactoryRun
    {
        public static void IMPAbstractFactory()
        {
            //Google
            IMobilePhone googleMobilePhone = new Google();
            MobileClient googleClient = new MobileClient(googleMobilePhone);

            Console.WriteLine("******* Google **********");
            Console.WriteLine(googleClient.GetSmartPhoneModelDetails());
            Console.WriteLine(googleClient.GetNormalPhoneModelDetails());

            //NOKIA
            IMobilePhone nokiaMobilePhone = new Nokia();
            MobileClient nokiaClient = new MobileClient(nokiaMobilePhone);

            Console.WriteLine("********* NOKIA **********");
            Console.WriteLine(nokiaClient.GetSmartPhoneModelDetails());
            Console.WriteLine(nokiaClient.GetNormalPhoneModelDetails());




            //SAMSUNG
            IMobilePhone samsungMobilePhone = new Samsung();
            MobileClient samsungClient = new MobileClient(samsungMobilePhone);

            Console.WriteLine("******* SAMSUNG **********");
            Console.WriteLine(samsungClient.GetSmartPhoneModelDetails());
            Console.WriteLine(samsungClient.GetNormalPhoneModelDetails());



        }
    }
}
