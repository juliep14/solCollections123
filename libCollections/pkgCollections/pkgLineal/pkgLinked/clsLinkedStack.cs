using pkgServices.pkgCollections.pkgLineal.pkgADT;
using pkgServices.pkgCollections.pkgLineal.pkgInterfaces;
using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgLinked
{
    public class clsLinkedStack<T> : clsADTLinked<T>, iStack<T> where T : IComparable<T>
    {
        #region Constructors
        public clsLinkedStack()
        {
        }
        #endregion

        public bool opPeek(ref T prmItem)
        {
            if (attLength == 0)
            {
                prmItem = default;
                return false;
            }
            else
            {
                prmItem = opGetLast().opGetItem(); 
                return true;
            }
        }
        public bool opPop(ref T prmItem)
        {
            if (attLength == 0)
            {
                prmItem = default;
                return false;
            }
            else
            {
                prmItem = opGetLast().opGetItem(); 
                opGoLast(); //
                return true;
            }
        }
        public bool opPush(T prmItem)
        {
            throw new NotImplementedException();
        }
    }
}
