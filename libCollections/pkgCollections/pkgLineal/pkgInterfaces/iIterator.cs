using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgInterfaces
{
    public interface iIterator<T> where T : IComparable<T>
    {
        #region Movement
        bool opGoFirst();
        bool opGoFirstQuarter();
        bool opGoPrevious();
        bool opGoMiddle();
        bool opGoLastQuarter();
        bool opGoNext();
        bool opGoLast();       
        bool opGo(int prmIdx);
        void opGoBack();
        void opGoForward();
        #endregion
        #region Getters
        int opGetLenght();
        int opGetCurrentIdx();
        T opGetCurrentItem();
        #endregion
        #region Setters
        bool SetCurrentItem(T prmContent);
        #endregion
        #region Query
        bool opIsValid(int prmIdx);
        bool opIsThereNext();
        bool opIsTherePrevious(); 
        #endregion

    }
}
