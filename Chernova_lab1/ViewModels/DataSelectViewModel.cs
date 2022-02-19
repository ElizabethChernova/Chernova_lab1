using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chernova_lab1.Models;
namespace Chernova_lab1.ViewModels
{
    class DataSelectViewModel
    {

        #region Field
        private UserCandidate user = new UserCandidate();

        #endregion
        #region Properties
        public string ZodiacWestern
        {
            get { return user.ZodiacWestern; }
            private set { user.ZodiacWestern = value; }

        }
        public int Age
        {
            get => user.Age;
            private set { user.Age = value; }
        }
        public Boolean HasBirthday
        {
            get => user.HasBirthday;
            private set { user.HasBirthday = value ; }
        }
        public DateTime DataOfBirth
        {
            get { return user.DataOfBirth; }
            set { user.DataOfBirth = value;
              Age=  CountAge();
                HasBirthday = DoHaveBirthday();
                ZodiacChineese = CountChineese();
                ZodiacWestern = CountWestern();
            }
        }

  
        public string ZodiacChineese
        {
            get { return user.ZodiacChineese; }
            private set { user.ZodiacChineese = value; }
        }
        #endregion
        private string CountWestern()
        {
         
            
                if ((user.DataOfBirth.Day >= 21 && user.DataOfBirth.Month == 3) || (user.DataOfBirth.Day <= 20 && user.DataOfBirth.Month == 4)) return "Овен";
                if ((user.DataOfBirth.Day >= 21 && user.DataOfBirth.Month == 4) || (user.DataOfBirth.Day <= 20 && user.DataOfBirth.Month == 5)) return "Телець ";
                if ((user.DataOfBirth.Day >= 21 && user.DataOfBirth.Month == 5) || (user.DataOfBirth.Day <= 21 && user.DataOfBirth.Month == 6)) return "Близнюки ";
                if ((user.DataOfBirth.Day >= 22 && user.DataOfBirth.Month == 6) || (user.DataOfBirth.Day <= 22 && user.DataOfBirth.Month == 7)) return "рак";
                if ((user.DataOfBirth.Day >= 23 && user.DataOfBirth.Month == 7) || (user.DataOfBirth.Day <= 23 && user.DataOfBirth.Month == 8)) return "лев";
                if ((user.DataOfBirth.Day >= 24 && user.DataOfBirth.Month == 8) || (user.DataOfBirth.Day <= 23 && user.DataOfBirth.Month == 9)) return "Діва";
                if ((user.DataOfBirth.Day >= 24 && user.DataOfBirth.Month == 9) || (user.DataOfBirth.Day <= 23 && user.DataOfBirth.Month == 10)) return "Терези ";
                if ((user.DataOfBirth.Day >= 24 && user.DataOfBirth.Month == 10) || (user.DataOfBirth.Day <= 22 && user.DataOfBirth.Month == 11)) return "Скорпіон ";
                if ((user.DataOfBirth.Day >= 23 && user.DataOfBirth.Month == 11) || (user.DataOfBirth.Day <= 21 && user.DataOfBirth.Month == 12)) return "Стрілець ";
                if ((user.DataOfBirth.Day >= 22 && user.DataOfBirth.Month == 12) || (user.DataOfBirth.Day <= 20 && user.DataOfBirth.Month == 1)) return "Козеріг ";
                if ((user.DataOfBirth.Day >= 21 && user.DataOfBirth.Month == 1) || (user.DataOfBirth.Day <= 18 && user.DataOfBirth.Month == 2)) return "Водолій ";
              else return "Риби ";
         
        }

        private string CountChineese()
        { 
               switch (user.DataOfBirth.Year % 12.0)
            {

                case 1:
           return"Півень";

                case 2:
                    return "Собака";
                case 3:
                    return "Свиня";
                case 4:
                    return "Щур";
                case 5:
                    return "Бик ";
                case 6:
                    return "Тигр ";
                case 7:
                    return "Кролик ";
                case 8:
         
                    return "Дракон ";
                case 9:
                    return "Змія ";
                case 10:
                    return "Кінь";
                case 11:
                    return "Коза";
                default:
                    return "Мавпа";
            }
        }

        private bool DoHaveBirthday()
        {
            return user.HasBirthday = DateTime.Today.Month == user.DataOfBirth.Month && DateTime.Today.Day == user.DataOfBirth.Day;
        }

        private int CountAge()
        {
            return DateTime.Today.Year - user.DataOfBirth.Year;
        }

    }
}
