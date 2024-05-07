using pkgServices.pkgCollections.pkgLineal.pkgInterfaces;
using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgIterators
{
    public class clsIterator<T> : iIterator<T> where T : IComparable<T>
    {
        #region Attributes
        protected int attLength = 0;
        protected int attCurrentIdx=-1;
        protected T attCurrentItem;
        #endregion
        #region Operations
        #region Movement
        public virtual bool opGoFirst()
        {
            throw new NotImplementedException();
        }
        public virtual bool opGoFirstQuarter()
        {
            throw new NotImplementedException();
        }
        public bool opGoPrevious()//confirmarsiesvirtual
        {
            if (!opIsTherePrevious())
                return false;
            opGoBack();
            return true;
        }
        public bool opGoMiddle()
        {
            throw new NotImplementedException();
        }
        public bool opGoLastQuarter()
        {
            throw new NotImplementedException();
        }
        public bool opGoNext()
        {
            if (!opIsThereNext()) return false;
            opGoForward();
            return true;
        }
        public virtual bool opGo(int prmIdx)
        {
            if (!opIsValid(prmIdx)) return false;
            opGoFirst();
            while (attCurrentIdx < prmIdx)
                opGoNext();
            return true;

        }
        public bool opGoLast()
        {
            throw new NotImplementedException();
        }
        public virtual void opGoBack()
        {
            attCurrentIdx--;
        }
        public virtual void opGoForward()
        {
            attCurrentIdx++;
        }
        #endregion
        #region Getters
        public int opGetCurrentIdx()
        {
            throw new NotImplementedException();
        }
        public T opGetCurrentItem()
        {
            throw new NotImplementedException();
        }
        public int opGetLenght()
        {
            throw new NotImplementedException();
        }
        #endregion

        public bool opIsValid(int prmIdx)
        {
            throw new NotImplementedException();
        }

        public bool SetCurrentItem(T prmContent)
        {
            throw new NotImplementedException();
        }

        public bool opIsThereNext()
        {
            if (attCurrentIdx >= attLength - 1) return false;
            return true;
        }

        public bool opIsTherePrevious()
        {
            if (attCurrentIdx <= 0) return false;
            return true;
        }

        #endregion
    }
}
