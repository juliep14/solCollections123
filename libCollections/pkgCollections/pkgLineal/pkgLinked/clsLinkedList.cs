﻿using pkgServices.pkgCollections.pkgLineal.pkgADT;
using pkgServices.pkgCollections.pkgLineal.pkgInterfaces;
using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgLinked
{
    public class clsLinkedList<T> : clsADTLinked<T>, iList<T> where T : IComparable<T>
    {
        #region Constructor
        public clsLinkedList()
        {

        }
        #endregion
        public bool opAdd(T prmItem)
        {
            throw new NotImplementedException();
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
