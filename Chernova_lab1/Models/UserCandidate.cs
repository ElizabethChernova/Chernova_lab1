using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chernova_lab1.Models
{
    class UserCandidate
    {
        #region Fields
        private DateTime _dataOfBirth;
        private string _zodiacWestern;
        private int _age;
        private Boolean _hasBirthday;
        private string _zodiacChineese;
       

            #endregion

            #region Properties
            public string ZodiacWestern
        {
            get { return _zodiacWestern; }
            set { _zodiacWestern = value; }
            
        }
        public int Age
        {
            get => _age;
             set { _age = DateTime.Today.Year - _dataOfBirth.Year; }
        }
        public Boolean HasBirthday
        {
            get => _hasBirthday;
             set { _hasBirthday = DateTime.Today.Month == _dataOfBirth.Month && DateTime.Today.Day == _dataOfBirth.Day; }
        }
        public DateTime DataOfBirth
        {
            get { return _dataOfBirth; }
            set { _dataOfBirth = value; }
        }
        public string ZodiacChineese
        {
            get { return _zodiacChineese; }
            set { _zodiacChineese = value; }
            }

        #endregion

        
    }
    
}
