using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace shopping
{
    internal class ListCourse
    {
        private List<Course> courses;

        public ListCourse()
        {
            courses = new List<Course>();
        }

        public void AddProduct(Course _item)
        {
            courses.Add(_item);
        }

        public void RemoveProduct(Course _item)
        {
            courses.Remove(_item);
        }

        public void DisplayListeCourse()
        {
            foreach(Course course in courses)
            {
                Console.WriteLine(course);
            }
        }

        public Course GetCourse(string input)
        {
            Course result = null;
            foreach (Course course in courses)
            {
                if (course.GetProduit(course).GetName() == input)
                {
                    result = course;
                }else
                {
                    Console.WriteLine("Le produit se situe dans aucune liste");
                }
            }
            return result;
        }

        public void GetCount()
        {
            int total_price = 0;
            foreach (Course course in courses)
            {
                total_price += course.GetProduit(course).GetPrice() * course.GetQuantite();
            }
            Console.WriteLine(total_price + "euros");
        }
    }
}
