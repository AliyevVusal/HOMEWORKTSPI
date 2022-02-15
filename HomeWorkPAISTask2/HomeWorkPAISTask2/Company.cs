using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkPAISTask2
{
    class Company
    {
        public string NameCompany;
        public int Limit;

        public Company(string namecompany,int limit)
        {
            NameCompant = namecompany;
            Limit = limit;
        }


        public string NameCompant
        {
            get { return NameCompant; }



            set
            {
                while (true)
                {

                    if (value.Length>8)
                    {

                    bool checkUpper = false;
                    bool checkLower = false;
                    bool checkDigist = false;
                    bool checksimvole = true;

                        for (int i = 0; i < value.Length; i++)
                        {

                            if (char.IsUpper(value[i]))
                            {
                                checkUpper = true;
                            }
                            if (char.IsDigit(value[i]))
                            {
                                checkDigist = true;
                            }
                            if (char.IsLower(value[i]))
                            {
                                checkLower = true;
                            }
                            if (char.IsSymbol(value[i]))
                            {
                                checksimvole = false;

                            }
                           
                            if (checkDigist && checkLower && checkUpper )
                            {
                                NameCompant = value;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Adi Duzgun daxil edin");
                                value = Console.ReadLine();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Company name 8 Simvoldan boyuk olmalidir");
                        value = Console.ReadLine();
                    }


                }

            }
        }




    }

}


