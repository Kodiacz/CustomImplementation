namespace CustomImplementation
{
    public class LinkedListItem<ItemType>
    {
        public LinkedListItem(ItemType value)
        {
            this.Value = value;
        }

        /// <summary>
        /// The value of the LinkedListItem
        /// </summary>
        public ItemType Value { get; set; }

        /// <summary>
        /// The previous item that is linked to the current LinkedListItem
        /// from the CustomLinkedList. If its null then the current LinkedListItem 
        /// is the first element of the CustomLinkedList
        /// </summary>
        public LinkedListItem<ItemType>? Previous { get; set; }

        /// <summary>
        /// The next item that is linked to the current LinkedListItem
        /// from the CustomLinkedList. If its null then the current LinkedListItem 
        /// is the last element of the CustomLinkedList
        /// </summary>
        public LinkedListItem<ItemType>? Next { get; set; }
    }
}
