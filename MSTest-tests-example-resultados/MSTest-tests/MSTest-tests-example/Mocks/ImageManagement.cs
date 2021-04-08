using System;

namespace MSTest_tests_example.Mocks.Date
{   
    public class ImageManagement
    {
        public string GetImageForTimeOfDay()
        {
            int currentHour = GetHour();

            if (currentHour > 6 && currentHour < 21)
                return "sun.jpg";
            else
                return "moon.jpg";
        }

        public virtual int GetHour(){
            return DateTime.Now.Hour;
        }
    }
}
