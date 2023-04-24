using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBindingCollectionsApp
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Married { set; get; }
        public string? Image { set; get; }
        //public override string ToString()
        //{
        //    return $"{Name} [{Age}] ({Married})";
        //}
    }
    public class DataContent
    {
        //public List<int> Numbers { get; set; } = new() { 1, 2, 3, 4, 5 };
        public ObservableCollection<User> Users { get; set; } = new()
        {
            new(){ Name = "Bob", Age = 24, Married = false, Image = "D:/images/image01.jpg" },
            new(){ Name = "Joe", Age = 29, Married = true, Image = "D:/images/image02.png" },
            new(){ Name = "Sam", Age = 32, Married = false, Image = "D:/images/image03.png" },
            new(){ Name = "Tim", Age = 26, Married = true, Image = "D:/images/image04.jpg" },
            new(){ Name = "Leo", Age = 37, Married = false, Image = "D:/images/image01.jpg" },
        };

    }
}
