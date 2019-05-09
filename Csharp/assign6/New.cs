using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment6
{
    class New : INews
    {
        int ID;
        String Title;
        String PublishDate;
        String Author;
        String Content;
        float AverageRate;
        int[] RateList = new int[3];

        public New(int iD, string title, string publishDate, string author, string content, int[] rateList)
        {
            ID = iD;
            Title = title;
            PublishDate = publishDate;
            Author = author;
            Content = content;
            RateList = rateList;
        }

        public void Display()
        {
            Console.WriteLine("Title" + this.Title + "PublishDate:" + this.PublishDate + "Author" + this.Author + "Content" + this.Content + "AverageRate" + this.AverageRate);
        }
        public float Calculate()
        {
            int total = 0;
            foreach (int item in RateList)
            {
                total += item;
            }
            this.AverageRate = total / 3;

            return this.AverageRate;

        }
    }
}
