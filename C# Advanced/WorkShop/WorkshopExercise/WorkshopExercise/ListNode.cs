﻿namespace CustomDoublyLinkedList
{
    public class ListNode<T>
    {
        public ListNode(T value)
        {
            this.Value = value;
        }
        
        public T Value { get; set; }

        public ListNode<T> NextNode { get; set; }

        public ListNode<T> PreviousNode { get; set; }

        //public override string ToString()     - правим го за по-удобно дебъгване
        //{
        //    return this.Value.ToString();
        //}
    }
}
