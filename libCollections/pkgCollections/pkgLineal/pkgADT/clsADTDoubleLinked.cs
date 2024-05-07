using pkgServices .pkgCollections.pkgNodes;
using System;
using pkgServices.pkgCollections.pkgLineal.pkgInterfaces;
using pkgServices.pkgCollections.pkgLineal.pkgIterators;

namespace pkgServices.pkgCollections.pkgLineal.pkgADT
{
    public class clsADTDoubleLinked<T> : clsADTLineal<T>, iADTDoubleLinked<T> where T : IComparable<T>
    {
        #region Attributes
        protected clsDoubleLinkedNode<T> attFirst;
        protected clsDoubleLinkedNode<T> attFirstQuarter;
        protected clsDoubleLinkedNode<T> attMiddle;
        protected clsDoubleLinkedNode<T> attLastQuarter;
        protected clsDoubleLinkedNode<T> attLast;
        protected clsDoubleLinkedNode<T> attCurrentNode;

        #endregion
        #region Operations
        #region Builders
        protected clsADTDoubleLinked()
        {
        }
        #endregion
        #region Getters
        public clsDoubleLinkedNode<T> opGetFirst()
        {
            throw new NotImplementedException();
        }
        public clsDoubleLinkedNode<T> opGetLast()
        {
            throw new NotImplementedException();
        }
        public clsDoubleLinkedNode<T> opGetMiddle()
        {
            throw new NotImplementedException();
        }
        public clsDoubleLinkedNode<T> opGetFirstQuarter()
        {
            throw new NotImplementedException();
        }
        public clsDoubleLinkedNode<T> opGetLastQuarter()
        {
            throw new NotImplementedException();
        }
      
        #endregion
        #region Setters
        public bool opSetFirst(clsDoubleLinkedNode<T> prmNode)
        {
            throw new NotImplementedException();
        }
        public bool opSetLast(clsDoubleLinkedNode<T> prmNode)
        {
            throw new NotImplementedException();
        }
        public bool opSetMiddle(clsDoubleLinkedNode<T> prmNode)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Iterator
        public override bool opGoFirst()
        {
            if (!opIsValid(0)) return false;
            attCurrentIdx = 0;
            attCurrentItem = attItems[attCurrentIdx];
            return true;
        }
        public override bool opGoFirstQuarter()
        {
            if (attFirstQuarter == null) return false;
            attCurrentItem = attFirstQuarter.opGetItem();
            attCurrentIdx = attLength/4;
            return true;
        }
        public override void opGoBack()
        {
            base.opGoBack();
            attCurrentNode = attCurrentNode.opGetPrevious();
            attCurrentItem = attCurrentNode.opGetItem();
        }
        #endregion
        #endregion
    }
}
