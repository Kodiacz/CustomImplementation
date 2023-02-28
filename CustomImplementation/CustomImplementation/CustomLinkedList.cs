namespace CustomImplementation
{
    public class CustomLinkedList<ItemType>
    {
        /// <summary>
        /// Property that gets the first element of the CustomLinkedList.
        /// </summary>
        public LinkedListItem<ItemType>? First { get; private set; }

        /// <summary>
        /// Property that gets the last element of the CustomLinkedList
        /// </summary>
        public LinkedListItem<ItemType>? Last { get; private set; }

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

        public ItemType[] ToArray()
        {
            throw new NotImplementedException();
        }
    }
}
