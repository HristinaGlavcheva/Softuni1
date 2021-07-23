﻿namespace Problem02.Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Stack<T> : IAbstractStack<T>
    {
        private Node<T> _top;

        public int Count { get; private set; }

        public bool Contains(T item)
        {
            bool contains = false;
            Node<T> currentNode = this._top;

            while (currentNode != null)
            {
                if(currentNode.Value.Equals(item))
                {
                    return true;
                }

                currentNode = currentNode.Next;
            }

            return contains;
        }

        public T Peek()
        {
            this.EnsureNotEmpty();

            return this._top.Value;
        }

        public T Pop()
        {
            this.EnsureNotEmpty();

            Node<T> poppedNode = this._top;
            this._top = this._top.Next;
            this.Count--;

            return poppedNode.Value;
        }

        public void Push(T item)
        {
            Node<T> newTop = new Node<T>(item);

            if (this._top == null)
            {
                this._top = newTop;
            }
            else
            {
                newTop.Next = this._top;
                this._top = newTop;
            }

            this.Count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> currentNode = this._top;

            while(currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();

        private void EnsureNotEmpty()
        {
            if(this._top == null)
            {
                throw new InvalidOperationException("The stack is empty!");
            }
        }
    }
}