using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FP
{
    public class HashTableEntry
    {
        public string Username;
        public string Password;

        public HashTableEntry(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }

    public class Hash
    {
        private HashTableEntry[] akun;
        private int size = 10;

        public Hash()
        {
            akun = new HashTableEntry[size];
        }

        public int GetHash(string username)
        {
            int hash = 0;
            foreach (char c in username)
            {
                hash += c;
            }
            return hash % size;
        }

        public bool CekDaftar(string username, string password)
        {
            int index = GetHash(username);
            int originalIndex = index;
            bool foundEmptySlot = false;

            while (akun[index] != null && akun[index].Username != username)
            {
                index = (index + 1) % size;
                if (index == originalIndex)
                {
                    return false;
                }
            }
            if (akun[index] == null)
            {
                akun[index] = new HashTableEntry(username, password);
                foundEmptySlot = true;
            }
            return foundEmptySlot;
        }

        public bool searchMasukPelanggan(string username, string password)
        {
            int i = 0;

            while (i < size)
            {
                if (akun[i] != null)
                {
                    if (akun[i].Username == username && akun[i].Password == password)
                    {
                        return true;
                    }
                }
                i++;
            }
            return false;
        }
    }
}