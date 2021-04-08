﻿using System;

namespace MSTest_tests_example.Mocks.Date
{   
    public class ImageManagement
    {
        public string GetImageForTimeOfDay()
        {
            //mecanismo que modifique la fecha del sistema
            int currentHour = getHour();

            if (currentHour > 6 && currentHour < 21)
                return "sun.jpg";
            else
                return "moon.jpg";
        }

        public virtual int getHour()
        {
            return DateTime.Now.Hour;
        }
    }
}
