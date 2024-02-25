using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace L1_13.Arsenii.Ziubin
{
    internal class ArrayOfPostCards
    {
        private Collector[] Collectors; // Collector data (array)
        public int Count { get; private set; } // Container size
        private int Capacity; // Container capacity
        /// <summary>
        /// Constructor (default capacity is 16)
        /// </summary>
        /// <param name="capacity"></param>
        public ArrayOfPostCards(int capacity = 16)
        {
            this.Capacity = capacity;
            this.Collectors = new Collector[capacity];
        }

        /// <summary>
        /// Creates a copy of student data (copy constructor)
        /// </summary>
        /// <param name="copy">Object from which data is copied</param>
        public ArrayOfPostCards(ArrayOfPostCards copy) : this(copy.Count) //call another constructor
        {
            for (int i = 0; i < copy.Count; i++)
            {
                Collector s = copy.Get(i);
                this.Add(new Collector(s)); // Calls copy constructor of Student
                                          // this.Add(new Student(s.NameSurname, s.L1, s.L2, s.L3, s.L4));
            }
        }

        /// <summary>
        /// Copies container elements (from left to right) if minimumCapacity > Capacity
        /// </summary>
        /// <param name="minimumCapacity">Minimum capacity of container</param>
        private void EnsureCapacity(int minimumCapacity)
        {
            if (minimumCapacity > this.Capacity)
            {
                Collector[] temp = new Collector[minimumCapacity];
                for (int i = 0; i < this.Count; i++)
                {
                    temp[i] = this.Collectors[i];
                }
                this.Capacity = minimumCapacity;
                this.Collectors = temp;
            }
        }

        /// <summary>
        /// Add element to the end of container
        /// </summary>
        /// <param name="student">Element to be added</param>
        public void Add(Collector student)
        {
            if (this.Count == this.Capacity) //container is full
            {
                EnsureCapacity(this.Capacity * 2);
            }
            this.Collectors[this.Count++] = student;
        }

        /// <summary>
        /// Gets element from container by index
        /// </summary>
        /// <param name="index">Element location (position) in container</param>
        /// <returns>Student object</returns>
        public Collector Get(int index)
        {
            return this.Collectors[index];
        }

        /// <summary>
        /// Search for element student in container
        /// </summary>
        /// <param name="student">Element that is searched</param>
        /// <returns>True if student is found in container (false otherwise)</returns>
        public bool Contains(Collector student)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.Collectors[i].Equals(student))
                {
                    return true;
                }
            }
            return false;
        }

        public void Sort()
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < this.Count - 1; i++)
                {
                    Collector a = this.Collectors[i];
                    Collector b = this.Collectors[i + 1];
                    if (a.CompareTo(b) < 0)
                    {
                        this.Collectors[i] = b;
                        this.Collectors[i + 1] = a;
                        flag = true;
                    }
                }
            }
        }

        // Removes element from container by index ( 0 <= index <= count)
        public void RemoveAt(int index)
        {
            if (index >= 0 && index <= this.Count)
            {
                for (int i = index; i < this.Count - 1; i++)
                    Collectors[i] = Collectors[i + 1];
                this.Count = this.Count - 1;
            }
        }
        // Removes element from container by value
        public void Remove(Collector s)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (Collectors[i].Equals(s))
                {
                    this.RemoveAt(i);
                }
            }
        }
        public void Insert(int index, Collector s)
        {
            // check for index out of bounds error
            if (index >= 0 && index <= this.Count)
            {
                if (this.Count == this.Capacity) //container is full
                {
                    EnsureCapacity(this.Capacity * 2);
                }
                // Insert element
                for (int i = this.Count; i > index; i--)
                    Collectors[i] = Collectors[i - 1];
                Collectors[index] = s;
                this.Count = this.Count + 1;
            }
        }

        public int CountColoredPostcardsFromCountry(string country)
        {
            int totalCount = 0;
            string type = "colored";
            for (int i = 0; i < Count; i++)
            {
                if (Get(i).Country.Equals(country) && Get(i).Type == type)
                {
                    totalCount += Get(i).Quantity;
                }
            }
            return totalCount;
        }

    }
}
