using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP
{
    public class LinkedlistMotor
    {
        public class Motor
        {
            public string Merk;
            public string NomorPolisi;
            public double Harga;

            public Motor(string merk, string nomorPolisi, double harga)
            {
                this.Merk = merk;
                this.NomorPolisi = nomorPolisi;
                this.Harga = harga;
            }
        }
        public class MotorNode
        {
            public Motor Data;
            public MotorNode? Next;

            public MotorNode(Motor data)
            {
                this.Data = data;
                this.Next = null;
            }
        }
        public class Garasi
        {
            public MotorNode? Head;

            public Garasi()
            {
                this.Head = null;
            }
            public void TambahMotor(Motor motor)
            {
                MotorNode newNode = new MotorNode(motor);
                newNode.Next = Head;
                Head = newNode;
            }

        }
    }
}
