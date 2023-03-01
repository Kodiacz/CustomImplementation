namespace CustomImplementation
{
    public class CustomStack<ItemType> 
    {
        /// <summary>
        /// field of type CustomLinkedList that conatains the items for
        /// CustomStack
        /// </summary>
        private CustomLinkedList<ItemType> linkedList = new CustomLinkedList<ItemType>();

        /// <summary>
        /// The count of the sequence in the <see cref="CustomStack{ItemType}"/>
        /// </summary>
        public int Count => this.linkedList.Count;

        /// <summary>
        /// Adds an item in the sequence of the <see cref="CustomStack{ItemType}"/>
        /// </summary>
        /// <param name="item">The item that will be stored in the sequence of the <see cref="CustomStack{ItemType}"/></param>
        public void Push(ItemType item)
        {
            linkedList.AddFirst(item);
        }

        /// <summary>
        /// Removes an item from the sequence of the <see cref="CustomStack{ItemType}"/>
        /// </summary>
        /// <returns>Returns the item that is going to be removed</returns>
        /// <exception cref="InvalidOperationException">If the sequence is empty</exception>
        public ItemType Pop()
        {
            if (linkedList.Count == 0)
            {
                throw new InvalidOperationException("The sequence is empty");
            }

            return linkedList.RemoveFirst();
        }

        /// <summary>
        /// Shows the first item in the sequence of the <see cref="CustomStack{ItemType}"/>.
        /// This method does not remove the item from the sequence
        /// </summary>
        /// <returns>Returns item of type <see cref="{ItemType}"/></returns>
        /// <exception cref="ArgumentNullException">Thrwos exception if the sequence is empty</exception>
        public ItemType Peek()
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
        public bool Contains(ItemType item)
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
