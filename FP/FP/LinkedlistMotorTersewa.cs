using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP
{
    public class LinkedlistMotorTersewa
    {
        public class MotorTersewa
        {
            public string Merk;
            public string NomorPolisi;
            public double Harga;
            public string NamaPenyewa;
            public string TanggalAwalSewa;
            public string TanggalAkhirSewa;

            public MotorTersewa(string merk, string nomorPolisi, string namaPenyewa, string tanggalAwalSewa, string tanggalAkhirSewa)
            {
                this.Merk = merk;
                this.NomorPolisi = nomorPolisi;
                this.NamaPenyewa = namaPenyewa;
                this.TanggalAwalSewa = tanggalAwalSewa;
                this.TanggalAkhirSewa = tanggalAkhirSewa;
            }
        }
        public class MotorTersewaNode
        {
            public MotorTersewa Data;
            public MotorTersewaNode? Next;

            public MotorTersewaNode(MotorTersewa data)
            {
                this.Data = data;
                this.Next = null;
            }
        }
        public class Tersewa
        {
            public MotorTersewaNode? Head;

            public Tersewa()
            {
                this.Head = null;
            }
            public void TambahMotorTersewa(MotorTersewa motorTersewa)
            {
                MotorTersewaNode newNode = new MotorTersewaNode(motorTersewa);
                newNode.Next = Head;
                Head = newNode;
            }

        }
    }
}