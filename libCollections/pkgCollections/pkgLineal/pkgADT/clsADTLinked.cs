using pkgServices.pkgCollections.pkgLineal.pkgInterfaces;
using pkgServices.pkgCollections.pkgNodes;
using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgADT
{
    public class clsADTLinked<T> : clsADTLineal<T>, iADTLinked<T> where T : IComparable<T>
    {
        #region Attributes
        protected clsLinkedNode<T> attFirst;
        protected clsLinkedNode<T> attFirstQuarter;
        protected clsLinkedNode<T> attMiddle;
        protected clsLinkedNode<T> attLastQuarter;
        protected clsLinkedNode<T> attLast;
        protected clsLinkedNode<T> attCurrentNode;
        #endregion
        #region Operations
        #region Builders
        protected clsADTLinked() { }
        #endregion
        #region Getters
        public clsLinkedNode<T> opGetFirst()
        {
            return attFirst;
        }
        public clsLinkedNode<T> opGetLast()
        {
            return attLast;
        }
        public clsLinkedNode<T> opGetMiddle()
        {
            return attMiddle;
        }
        public clsLinkedNode<T> opGetFirstQuarter()
        {
            return attFirstQuarter;
        }
        public clsLinkedNode<T> opGetLastQuarter()
        {
            return attLastQuarter;
        }
        #endregion
        #region Setters
        public bool opSetFirst(clsLinkedNode<T> prmNode)
        {
            throw new NotImplementedException();
        }
        public bool opSetLast(clsLinkedNode<T> prmNode)
        {
            throw new NotImplementedException();
        }
        public bool opSetMiddle(clsLinkedNode<T> prmNode)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Iterators
        public override bool opGoFirst()
        {
            if (attFirst==null) return false;
            attCurrentItem = attFirst.opGetItem();
            attCurrentIdx = 0;
            return true;
        }
        public override bool opGoFirstQuarter()
        {
            if (attFirstQuarter == null) return false;
            attCurrentItem = attFirstQuarter.opGetItem();
            attCurrentIdx = attLength/4;
            return true;
        }
        public override bool opGo(int prmIdx)
        {
            if (!opItsValid(prmIdx)) return false;
            if (prmIdx < attLength / 4) opGoFirst();
            if (prmIdx >= (attLength / 4) && prmIdx < attLength / 2) opGoFirstQuarter();
            if (prmIdx >= (attLength / 2 + attLength / 4) && prmIdx < attLength / 2 + attLength) opGoLastQuarter();
            if (prmIdx >= attLength-1) opGoLast();
            while (attCurrentIdx < prmIdx) ;
            opGoNext();
            return true;
        }
        public override void opGoForward()
        {
            base.opGoForward();
            attCurrentNode = attCurrentNode.opGetNext();
            attCurrentItem = attCurrentNode.opGetItem();
        }
        #endregion
        #endregion
    }
}
