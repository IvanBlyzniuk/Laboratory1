using System;

namespace Laboratory1.Models
{
    internal class User
    {
        private DateTime dateOfBirth = DateTime.Today;
        public DateTime DateOfBirth { 
            get => dateOfBirth; 
            set => dateOfBirth = value; 
        }
        public string WesternZodiac()
        { 
                if (DateOfBirth.Month == 3 && DateOfBirth.Day >= 21 || DateOfBirth.Month == 4 && DateOfBirth.Day <= 20)
                    return "Aries ♈︎";
                if (DateOfBirth.Month == 4 && DateOfBirth.Day >= 21 || DateOfBirth.Month == 5 && DateOfBirth.Day <= 20)
                    return "Taurus ♉︎";
                if (DateOfBirth.Month == 5 && DateOfBirth.Day >= 21 || DateOfBirth.Month == 6 && DateOfBirth.Day <= 21)
                    return "Gemini ♊︎";
                if (DateOfBirth.Month == 6 && DateOfBirth.Day >= 22 || DateOfBirth.Month == 7 && DateOfBirth.Day <= 22)
                    return "Cancer ♋︎";
                if (DateOfBirth.Month == 7 && DateOfBirth.Day >= 23 || DateOfBirth.Month == 8 && DateOfBirth.Day <= 22)
                    return "Leo ♌︎";
                if (DateOfBirth.Month == 8 && DateOfBirth.Day >= 23 || DateOfBirth.Month == 9 && DateOfBirth.Day <= 22)
                    return "Virgo ♍︎";
                if (DateOfBirth.Month == 9 && DateOfBirth.Day >= 23 || DateOfBirth.Month == 10 && DateOfBirth.Day <= 22)
                    return "Libra ♎︎";
                if (DateOfBirth.Month == 10 && DateOfBirth.Day >= 23 || DateOfBirth.Month == 11 && DateOfBirth.Day <= 22)
                    return "Scorpio ♏︎";
                if (DateOfBirth.Month == 11 && DateOfBirth.Day >= 23 || DateOfBirth.Month == 12 && DateOfBirth.Day <= 21)
                    return "Sagittarius ♐︎";
                if (DateOfBirth.Month == 12 && DateOfBirth.Day >= 22 || DateOfBirth.Month == 1 && DateOfBirth.Day <= 20)
                    return "Capricorn ♑︎";
                if (DateOfBirth.Month == 1 && DateOfBirth.Day >= 21 || DateOfBirth.Month == 2 && DateOfBirth.Day <= 19)
                    return "Aquarius ♒︎";
                return "Pisces ♓︎";
        }
        public string ChineseZodiac()
        {
            switch(DateOfBirth.Year%12)
            {
                case 0: return "Monkey";
                case 1: return "Rooster";
                case 2: return "Dog";
                case 3: return "Pig";
                case 4: return "Rat";
                case 5: return "Ox";
                case 6: return "Tiger";
                case 7: return "Rabbit";
                case 8: return "Dragon";
                case 9: return "Snake";
                case 10: return "Horse";
                default: return "Goat";
            }
        }

        public bool DateOfBirthIsValid()
        {
            return Age() >= 0 && Age() <= 135;
        }

        public int Age()
        {
            if(DateTime.Today.Year == DateOfBirth.Year)
            {
                if (DateTime.Today.Month > DateOfBirth.Month || (DateTime.Today.Month == DateOfBirth.Month && DateTime.Today.Day >= DateOfBirth.Day))
                    return 0;
                return -1;
            }
            if (DateTime.Today.Month >= DateOfBirth.Month && DateTime.Today.Day >= DateOfBirth.Day)
                return DateTime.Today.Year - DateOfBirth.Year;
            return DateTime.Today.Year - DateOfBirth.Year - 1;
        }

        public bool BirthDayToday()
        {
            return DateOfBirth.Month == DateTime.Today.Month && DateOfBirth.Day == DateTime.Today.Day;
        }
    }
}
