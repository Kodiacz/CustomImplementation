namespace CustomImplementation
{
    public class CustomStack<StackItem> 
    {
        /// <summary>
        /// field of type <see cref="CustomLinkedList{StackItem}"/> that conatains the items for
        /// <see cref="CustomStack{StackItem}"/>
        /// </summary>
        private CustomLinkedList<StackItem> linkedList = new CustomLinkedList<StackItem>();

        /// <summary>
        /// The count of the sequence in the <see cref="CustomStack{StackItem}"/>
        /// </summary>
        public int Count => this.linkedList.Count;

        /// <summary>
        /// Adds an item in the sequence of the <see cref="CustomStack{StackItem}"/>
        /// </summary>
        /// <param name="item">The item that will be stored in the sequence of the <see cref="CustomStack{StackItem}"/></param>
        public void Push(StackItem item)
        {
            linkedList.AddFirst(item);
        }

        /// <summary>
        /// Removes an item from the sequence of the <see cref="CustomStack{StackItem}"/>
        /// </summary>
        /// <returns>Returns the item that is going to be removed</returns>
        /// <exception cref="InvalidOperationException">If the sequence is empty</exception>
        public StackItem Pop()
        {
            if (linkedList.Count == 0)
            {
                throw new InvalidOperationException("The sequence is empty");
            }

            return linkedList.RemoveFirst();
        }

        /// <summary>
        /// Shows the first item in the sequence of the <see cref="CustomStack{StackItem}"/>.
        /// This method does not remove the item from the sequence
        /// </summary>
        /// <returns>Returns item of type <see cref="{StackItem}"/></returns>
        /// <exception cref="ArgumentNullException">Thrwos exception if the sequence is empty</exception>
        public StackItem Peek()
        {
            if (linkedList.First == null)
            {
                throw new ArgumentNullException("They are no items in the sequence");
            }

            return linkedList.First.Value;
        }

        /// <summary>
        /// Checks if sequence contains the <paramref name="item"/>
        /// </summary>
        /// <param name="item">item of type </param>
        /// <returns></returns>
        public bool Contains(StackItem item)
        {
            var array = this.linkedList.ToArray();

            foreach (var element in array)
            {
                if (element.Equals(item))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
