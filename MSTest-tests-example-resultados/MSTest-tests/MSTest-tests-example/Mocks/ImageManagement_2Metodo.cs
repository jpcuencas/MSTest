using System;

namespace MSTest_tests_example.Mocks.Date
{   
    public class ImageManagement_2Metodo
    {
        public string GetImageForTimeOfDay(IDate date)
        {
            int currentHour = date.GetHour();

            if (currentHour > 6 && currentHour < 21)
                return "sun.jpg";
            else
                return "moon.jpg";
        }
    }

    public interface IDate
    {
        int GetHour();
    }
}
