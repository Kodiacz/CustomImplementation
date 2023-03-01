namespace CustomImplementation
{
    public class CustomQueue<QueueItem>
    {
        /// <summary>
        /// field of type <see cref="CustomLinkedList{QueueItem}"/> that conatains the items for
        /// <see cref="CustomQueue{QueueItem}"/>
        /// </summary>
        private CustomLinkedList<QueueItem> linkedList = new CustomLinkedList<QueueItem>();

        /// <summary>
        /// The count of the sequence in the <see cref="CustomQueue{QueueItem}"/>
        /// </summary>
        public int Count => this.linkedList.Count;

        /// <summary>
        /// Adds an item in the sequence of the <see cref="CustomQueue{QueueItem}"/>
        /// </summary>
        /// <param name="item">The item that will be stored in the sequence of the <see cref="CustomQueue{QueueItem}"/></param>
        public void Enqueue(QueueItem item)
        {
            linkedList.AddFirst(item);
        }

        /// <summary>
        /// Removes an item from the sequence of the <see cref="CustomQueue{QueueItem}"/>
        /// </summary>
        /// <returns>Returns the item that is going to be removed</returns>
        /// <exception cref="InvalidOperationException">If the sequence is empty</exception>
        public QueueItem Dequeue()
        {
            if (linkedList.Count == 0)
            {
                throw new InvalidOperationException("The sequence is empty");
            }

            return linkedList.RemoveLast();
        }

        /// <summary>
        /// Shows the first item in the sequence of the <see cref="CustomQueue{QueueItem}"/>.
        /// This method does not remove the item from the sequence
        /// </summary>
        /// <returns>Returns item of type <see cref="{QueueItem}"/></returns>
        /// <exception cref="ArgumentNullException">Thrwos exception if the sequence is empty</exception>
        public QueueItem Peek()
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
        public bool Contains(QueueItem item)
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
