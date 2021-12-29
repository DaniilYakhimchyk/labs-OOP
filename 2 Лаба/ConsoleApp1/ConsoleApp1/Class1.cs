using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public partial class pHONE
    {
        private const int maxid=9999999;
        private int id;
        private static int count;
        private string fio;
        private string address;
        private int number;
        private int debit;
        private int credit;
        private int time1;
        private int time2;


        public int Count
        {
            get { return count; }
            
        }
        public int Id
        {
            get { 
                return id; 
                }
            set
            {
                if (value <= maxid)
                    id = value;
                else
                    Console.WriteLine("Неверное ID");
            }
        }
        public string FIO
        {
            get { return fio; }
            set { fio = value; }

        }
        public string Address
        {
            get { return address; }
            set { address = value; }

        }
        public int Number
        {
            get { return number; }
            set { number = value; }

        }
        public int Debit
        {
            get { return debit; }
            set { debit = value; }

        }
        public int Credit
        {
            get { return credit; }
            set { credit = value; }

        }
        public int Time1
        {
            get { return time1; }
            set
            {
                if (value >= 0)
                    time1 = value;
                else
                    Console.WriteLine("Неверный номер");
            }
        }
            public int Time2
        {
            get
            {
                return Time2;
            }
            set
            {
                if (value >= 0)
                    time2 = value;
                else
                    Console.WriteLine("Неверный номер");
            }

        }
        public pHONE( int id, string fio, string address, int number, int debit, int credit, int time1, int time2)
        {
            if (id <= maxid && time1 >= 0 && time1 >= 0)
            {
                this.id = id;
                this.fio = fio;
                this.address = address;
                this.number = number;
                this.debit = debit;
                this.credit = credit;
                this.time1 = time1;
                this.time2 = time2;
                pHONE.count++;
            }
            else
                throw new Exception("Некоректрый ввод!");

        }
        public int Balans()
        {
           
            return this.debit - this.credit;
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }

}
