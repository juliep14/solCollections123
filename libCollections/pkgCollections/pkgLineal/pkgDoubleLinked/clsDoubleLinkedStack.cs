using System;
using pkgServices.pkgCollections.pkgLineal.pkgADT;
using pkgServices.pkgCollections.pkgLineal.pkgInterfaces;

namespace pkgServices.pkgCollections.pkgLineal.pkgDoubleLinked
{
    public class clsDoubleLinkedStack<T> : clsADTDoubleLinked<T>, iStack<T> where T : IComparable<T>
    {
        #region Constructors
        public clsDoubleLinkedStack()
        {

        }
        #endregion
        #region CRUDs
        public bool opPeek(ref T prmItem)
        {
            if (attLength == 0)
            {
                prmItem = default;
                return false;
            }
            prmItem = attLast.opGetItem();
            return true;
        }
        public bool opPop(ref T prmItem)
        {
            if (attLength == 0)
            {
                prmItem = default;
                return false;
            }
            prmItem = attLast.opGetItem();
            attLast = attLast.attPrevious;
            if (attLast != null)
            {
                attLast.attNext = null;
            }
            else
            {
                attFirst = null; 
            }
            attLength--;
            return true; 
        }
        public bool opPush(T prmItem)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
