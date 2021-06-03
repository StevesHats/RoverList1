using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    public class RoverList<T> : RoverListBase<T>
    {
        // Add any variables you need here

        public RoverList()
        {
        }

        public override int Count => throw new NotImplementedException();

        //custom add first node so that the beggining isn't null and the rest of the code will work
        public override void Starter(T data)
        {

            Node Nnode = new RoverListBase<T>.Node(data);

            head = Nnode;

        }

        //custom checks length of data for odd or even then removes the nodes


        //only for strings
        /*
        public override void OddCheck()
        {
            string answer;

            Node temp;


            current = head;

            int pita = 0;

            int lengthOfString;

            while (current != null)
            {
                answer = current.Data.ToString();

                lengthOfString = answer.Length;

                if (lengthOfString % 2 != 0)
                {
                    temp = current;
                    RemoveAt(pita);
                    current = current.Next;
                }
                else
                {
                    current = current.Next;
                }

                pita++;

                
            }
            

        }
        */



        //custom removes last node

        public  override bool RemoveLast()
        {
            current = head;
            
            while (current != null)
            {
                if (current.Next.Next == null)
                {
                    current.Next = null;
                }

                current = current.Next;
            }


            return true;
        }


        public override void Add(T data)
        {

            Node Nnode = new RoverListBase<T>.Node(data);

            current = head;
            
            int x = 0;

            //go to the end
            while (current != null && x == 0)
            { 
                if (current.Next == null)
                {
                    current.Next = Nnode;

                    //stop the loop
                    x++;
                }
                else
                {
                    current = current.Next;
                }
            }

            

        }

        public override void Add(int Position, T data)
        {
            //assuming we starting at 0
            int toast = 0;

            Node Nnode = new RoverListBase<T>.Node(data);

            current = head;

            if (Position == 0)
            {
                Nnode.Next = current;

                head = Nnode;
            }

            while (current != null)
            {
                if (toast++ == Position)
                {
                    Nnode.Next = current.Next;

                    current.Next = Nnode;

                }

                current = current.Next;
 
            }


        }

        public override void Clear()
        {
            head = null;

            Console.WriteLine("data cleared");
        }

        public override T ElementAt(int Position)
        {
            current = head;

            int x = 0;

            for (int toast = 0; toast <= Position++; toast++)
            {
                if (toast == Position)
                {
                    return current.Data;
                    x+=2;
                }


                if (x == 0 && current.Next != null)
                {
                    current = current.Next;
                }

                if (x == 0 && current.Next == null)
                {
                    Console.WriteLine("Position not Found");
                    toast += 10;
                }
                    
            }


            return current.Data;

        }

        public override void ListNodes()
        {
            current = head;

            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
         
        }

        public override bool RemoveAt(int Position)
        {
            current = head;

            int x = 0;

            if (Position == 0)
            {
                head = current.Next;
                current = head;
            }
            else
            {


                for (int toast = 0; toast <= Position; toast++)
                {
                    if (toast++ == Position)
                    {
                        current.Next = current.Next.Next;
                        x++;
                    }

                    //safely continue
                    if (x == 0 && current.Next != null)
                    {
                        current = current.Next;
                    }

                    if (x == 0 && current.Next == null)
                    {
                        Console.WriteLine("Position not Found");
                        toast += 10;
                    }
                }

            }

            return true;

        }
    }
}
