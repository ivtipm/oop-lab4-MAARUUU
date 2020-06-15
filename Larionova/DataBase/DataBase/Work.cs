using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;

namespace DataBase
{
   public  class Work
    {
        ArrayList memberProfile = new ArrayList(); // коллекция

        public ArrayList MemberProfile
        {
            get
            {
                return memberProfile;
            }
        }

       // добавить модель в коллекцию
        public void AddProfile(MemberProfile memberProfile)
        {
            MemberProfile.Add(memberProfile);
        }

        // сохранение коллекции в файл
        public void SaveToFile(string filename)
        {
            using (StreamWriter file = new StreamWriter(filename, false, System.Text.Encoding.Unicode))
            {
                foreach (MemberProfile m in memberProfile)
                {
                    file.WriteLine(m.ToString());
                }
            }
        }

      
        // восстанавливает коллекцию, записанную в файл
        public void OpenFile(string filename)
        {
            if (!System.IO.File.Exists(filename))
                throw new Exception("Файл не существует");
            if (memberProfile.Count != 0)
                DeleteModel();
            using (StreamReader sw = new StreamReader(filename))
            {
                while (!sw.EndOfStream)
                {
                        string str = sw.ReadLine();
                        String[] dataFromFile = str.Split(new String[] { "|" },
                        StringSplitOptions.RemoveEmptyEntries);
                        string modelFullName = dataFromFile[0];
                        string modelName = dataFromFile[1];
                        ushort year = (ushort)Convert.ToInt32(dataFromFile[2]);
                        byte weight = (byte)Convert.ToInt32(dataFromFile[3]);
                        byte height = (byte)Convert.ToInt32(dataFromFile[4]);
                        MemberProfile file = new MemberProfile(modelFullName, modelName, year, weight, height);
                        AddProfile(file);
                }
            }
        }

        
        // удаление элемента  по индексу
        public void DeleteModeleProfile(int number) => memberProfile.RemoveAt(number);

        
        // поиск по фамилии и имени 
        // вернёт индексо найденных элементов
        public List<int> SearchModel(string query)
        {
            List<int> count = new List<int>();
            for (int i = 0; i < memberProfile.Count; i++)
            {
                MemberProfile model = (MemberProfile)memberProfile[i];
                if (model.ModelFullname.ToLower().Replace(" ", "").Contains(query))
                    count.Add(i);
                else
                    if (model.ModelName.ToLower().Replace(" ", "").Contains(query))
                    count.Add(i);
            }
            if (count.Count == 0)
                count.Add(-1);
            return count;
        }

        // удаление всей коллекции
        public void DeleteModel() => memberProfile.Clear();

        // сортировка коллекции
        public void Sort(SortDirection direction)
        {
            memberProfile.Sort(new YearComparer(direction));
        }
    }

    // сортировка коллекции
    public enum SortDirection
    {
        Ascending,
        Descending
    }

    public class YearComparer : IComparer
    {
        private SortDirection m_direction = SortDirection.Ascending;

        public YearComparer() : base() { }

        public YearComparer(SortDirection direction)
        {
            this.m_direction = direction;
        }

        int IComparer.Compare(object x, object y)
        {
            MemberProfile memberProfile1 = (MemberProfile)x;
            MemberProfile memberProfile2 = (MemberProfile)y;

            return (this.m_direction == SortDirection.Ascending) ?
               memberProfile1.YearBirth.CompareTo(memberProfile2.YearBirth) :
                memberProfile2.YearBirth.CompareTo(memberProfile1.YearBirth);
        }
    }
}
