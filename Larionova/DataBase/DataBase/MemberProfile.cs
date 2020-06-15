using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
   public  class MemberProfile
    {
        string modelFullname; // фамилия модели
        string modelName; // имя модели
        ushort yearBirth; // год рождения
        byte modelHeight; // рост модели
        byte modelWeight; // вес модели
    

        // конструктор 
    public MemberProfile(string fullname,string name, ushort year,byte height,byte weight)
    {
        if((fullname == "") ||(name == ""))
            throw new Exception("Все поля должны быть заполнены");
            modelFullname = fullname;
            modelName = name;
            yearBirth = year;
            modelHeight = height;
            modelWeight = weight;
    }

        public string ModelFullname
        {
            get
            {
                return modelFullname;
            }

            set
            {
                modelFullname = value;
            }
        }

        public string ModelName
        {
            get
            {
                return modelName;
            }

            set
            {
                modelName = value;
            }
        }



        public ushort YearBirth
         {
             get
             {
                return yearBirth;
             }

             set
             {
              yearBirth = value;
             }
         }


        public byte ModelHeight
        {
            get
            {
                return modelHeight;
            }

            set
            {
                modelHeight = value;
            }
        }


        public byte ModelWeight
        {
            get
            {
                return modelWeight;
            }

            set
            {
                modelWeight = value;
            }
        }


        public override string ToString()
        {
            return modelFullname + "|" + modelName + "|" + yearBirth + "|" + modelHeight + "|" + modelWeight;
        }
    }
 }