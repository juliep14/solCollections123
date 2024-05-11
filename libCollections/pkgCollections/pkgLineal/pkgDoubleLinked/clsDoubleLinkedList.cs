using pkgServices.pkgCollections.pkgLineal.pkgADT;
using pkgServices.pkgCollections.pkgLineal.pkgInterfaces;
using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgDoubleLinked
{
    public class clsDoubleLinkedList<T> : clsADTDoubleLinked<T>, iList<T> where T : IComparable<T>
    {
        public clsDoubleLinkedList()
        {

        }
        public bool opAdd(T prmItem)
        {
            if (attLength >= attTotalCapacity)
            {
                return false;
            }
            if (attTotalCapacity == attLength)
            {
                attItems[attTotalCapacity - 1] = prmItem;
                attLength++;
                return true;
            }
            else
            {
                attItems[attLength] = prmItem;
                attLength++;
                return true;
            }
        }
        public bool opInsert(int Idx, T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opRemove(int Idx, ref T prmItem)
        {
            throw new NotImplementedException();
        }
    }
}
