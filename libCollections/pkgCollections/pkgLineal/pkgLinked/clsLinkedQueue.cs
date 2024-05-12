using pkgServices.pkgCollections.pkgLineal.pkgADT;
using pkgServices.pkgCollections.pkgLineal.pkgInterfaces;
using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgLinked
{
    public class clsLinkedQueue<T> : clsADTLinked<T>, iQueue<T> where T : IComparable<T>
    {
        #region Constructor
        public clsLinkedQueue()
        {

        }
        public clsLinkedQueue(int prmCapacity, int attTotalCapacity)
        {
            try
            {
                if (prmCapacity < 0)
                {
                    prmCapacity = 100;
                    attTotalCapacity = 100;
                }
                if (prmCapacity == 0)
                {
                    prmCapacity = 100;
                    attTotalCapacity = 100;
                }
                if (attLength < 0) attLength = 0;
                attItems = new T[prmCapacity];
            }
            catch
            {
                attTotalCapacity = 100;
                attMaxCapacity = int.MaxValue / 16;
                attItems = new T[100];
            }
        }
        #endregion
        public bool opPeek(ref T prmItem)
        {
            if (attItems == null)
            {
                T[] prmArray = new T[100];
                attItems = prmArray;
                return false;
            }
            //if (attFirst == null) return false;
            prmItem = attItems[0];
            return true;
            /*if (attItems == null || attItems.Length == 0)
            {
                return false; 
            }
            prmItem = attItems[0];
            return true;*/
        }
        public bool opPop(ref T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opPush(T prmItem)
        {
            throw new NotImplementedException();
        }
    }
}
