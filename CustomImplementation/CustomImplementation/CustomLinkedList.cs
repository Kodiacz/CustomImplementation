namespace CustomImplementation
{
    public class CustomLinkedList<ItemType>
    {
        /// <summary>
        /// Property that gets the first element of the <see cref="CustomLinkedList{ItemType}"/> sequence.
        /// </summary>
        public LinkedListItem<ItemType>? First { get; private set; }

        /// <summary>
        /// Property that gets the last element of the <see cref="CustomLinkedList{ItemType}"/> sequence.
        /// </summary>
        public LinkedListItem<ItemType>? Last { get; private set; }

        public int Count => this.GetCount(this.First);

        /// <summary>
        /// Adds the first element of the CustomLinkedList sequence.
        /// </summary>
        /// <param name="value">The value of the property <see cref="First"/></param>
        public void AddFirst(ItemType value)
        {
            if (this.First == null)
            {
                this.First = new LinkedListItem<ItemType>(value);
                this.Last = this.First;
            }
            else if (this.First == this.Last)
            {
                this.First = new LinkedListItem<ItemType>(value);
                this.First.Next = this.Last;
                this.Last.Previous = this.First;
            }
            else
            {
                var tempItem = this.First;
                this.First = new LinkedListItem<ItemType>(value);
                this.First.Next = tempItem;
                this.First.Next.Previous = this.First;
            }
        }

        /// <summary>
        /// Adds the last element of the <see cref="CustomLinkedList{ItemType}"/> sequence.
        /// </summary>
        /// <param name="value">The value of the property <see cref="Last"/>.</param>
        public void AddLast(ItemType value)
        {
            if (this.First == null)
            {
                this.First = new LinkedListItem<ItemType>(value);
                this.Last = this.First;
            }
            else if (this.Last == this.First)
            {
                this.Last = new LinkedListItem<ItemType>(value);
                this.Last.Previous = this.First;
                this.First.Next = this.Last;
            }
            else
            {
                var tempItem = new LinkedListItem<ItemType>(value);
                tempItem.Previous = this.Last;
                this.Last!.Next = tempItem;
                this.Last = tempItem;
            }
        }

        /// <summary>
        /// Removes the first element of the <see cref="CustomLinkedList{ItemType}"/> sequence.
        /// </summary>
        /// <returns>The value of the first element</returns>
        /// <exception cref="InvalidOperationException">throws an exception if the sequence is empty</exception>
        public ItemType RemoveFirst()
        {
            if (this.First == null)
            {
                throw new InvalidOperationException("CustomLinkedList contains no elements");
            }

            var valueToReturn = this.First.Value;

            if (this.First.Next == null)
            {
                this.First = null;
                this.Last = null;
            }
            else
            {
                this.First = this.First.Next;
                this.First.Previous = null;
            }

            return valueToReturn;
        }

        /// <summary>
        /// Removes the last element of the <see cref="CustomLinkedList{ItemType}"/> sequence.
        /// </summary>
        /// <returns>The value of the last element</returns>
        /// <exception cref="InvalidOperationException">throws an exception if the sequence is empty</exception>
        public ItemType RemoveLast()
        {
            if (this.First == null)
            {
                throw new InvalidOperationException("CustomLinkedList contains no elements");
            }

            var valueToReturn = this.Last!.Value;

            if (this.Last.Previous == null)
            {
                this.First = null;
                this.Last = null;
            }
            else
            {
                this.Last = this.Last.Previous;
                this.Last.Next = null;
            }

            return valueToReturn;
        }

        /// <summary>
        /// Convert the <see cref="CustomLinkedList{ItemType}"/> sequence into an <see cref="Array"/>
        /// </summary>
        /// <returns>returns an <see cref="Array"/> that contains the items of the <see cref="CustomLinkedList{ItemType}"/> sequence</returns>
        /// <exception cref="NotImplementedException"></exception>
        public ItemType[] ToArray()
        {
            var array = new ItemType[this.Count];
            var currentItem = this.First;
            var index = 0;

            while (currentItem != null)
            {
                array[index++] = currentItem.Value;
                currentItem = currentItem.Next;
            }

            return array;
        }

        /// <summary>
        /// Iterates through all items and performs a certain action
        /// </summary>
        /// <param name="action">Delegate of type <see cref="Action"/> that accepts one argument of type <see cref="LinkedListItem{ItemType}"/></param>
        public void ForEach(Action<LinkedListItem<ItemType>> action)
        {
            var currentItem = this.First;

            while (currentItem != null)
            {
                action(currentItem);
                currentItem = currentItem.Next;
            }
        }

        /// <summary>
        /// Gets the count of the <see cref="CustomLinkedList{ItemType}"/> sequence
        /// </summary>
        /// <param name="item">The current item of the CustomLinkedList sequence</param>
        /// <returns>Returns an integer that contains the count of the CustomLInkedList sequence</returns>
        private int GetCount(LinkedListItem<ItemType>? item)
        {
            if (item == null)
            {
                return 0;
            }

            return 1 + GetCount(item.Next);
        }
    }
}
