﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{

    public class PriorityQueueArray
    {
        Model[] array;
        int rear = -1;


        public PriorityQueueArray(int len)
        {
            array = new Model[len];
        }

        public bool IsFull()
        {
            if (rear >= array.Length - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsEmpty()
        {
            if (rear == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Enqueue(string value, int priortiy)
        {
            if (!IsFull())
            {
                var newNode = new Model(value, priortiy);
                rear++;
                array[rear] = newNode;
            }
            else
            {
                Console.WriteLine("Full!");
            }
        }


        public void Dequeue()
        {
            if (!IsEmpty())
            {
                int MinimumItemindex = array[0].Priortiy;
                int index = 0;
                for (int i = 1; i < rear; i++)
                {
                    if (array[i].Priortiy < MinimumItemindex)
                    {
                        index = i;
                    }
                }
                var minimumItem = "Poped Value : " + array[index].Value + " Priortiy : " + array[index].Priortiy;
                Console.WriteLine(minimumItem);

                array[index] = array[rear];
                rear--;
            }
            else
            {
                Console.WriteLine("Empty!");
            }
        }


        public void PrintElements()
        {
            if (!IsEmpty())
            {
                for (int i = 0; i <= rear; i++)
                {
                    var x = "Items : \n" + array[i].Value + " " + array[i].Priortiy;
                    Console.WriteLine(x);
                }
            }
            else
            {
                Console.WriteLine("Queue is empty");
            }
        }

    }

    public class Model
    {
        public string Value { get; private set; }
        public int Priortiy { get; private set; }

        public Model(string value, int priortiy)
        {
            Value = value;
            Priortiy = priortiy;
        }
    }
}
