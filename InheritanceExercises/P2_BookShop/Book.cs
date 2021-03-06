﻿namespace P02_BookShop
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Book
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        public string Title
        {
            get { return this.title; }
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentException("Author not valid!");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                this.title = value;
            }
        }
        public string Author
        {
            get { return this.author; }
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentException("Author not valid!");
                }
                string[] names = value.Split();
                if (names.Count() < 2)
                {
                    throw new ArgumentException("Author not valid!");
                }
                string pattern = @"^\d";
                Match match = Regex.Match(names[1], pattern);
                if (match.Success)
                {
                    throw new ArgumentException("Author not valid!");
                }
                this.author = value;
            }
        }
        public virtual decimal Price
        {
            get { return this.price; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Type: ").AppendLine(this.GetType().Name)
                .Append("Title: ").AppendLine(this.Title)
                .Append("Author: ").AppendLine(this.Author)
                .Append("Price: ").Append($"{this.Price:f1}")
                .AppendLine();

            return sb.ToString();
        }
    }
}
