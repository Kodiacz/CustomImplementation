namespace CustomImplementation.Test
{
    public class CustomLinkedListTest
    {
        [Fact]
        public void AddFirst_OneValue_Test()
        {
            var linkedList = new CustomLinkedList<int>();
            linkedList.AddFirst(1);
            Assert.Equal(1, linkedList.Count);
        }

        [Fact]
        public void AddFirst_OneValue_Null_Test()
        {
            var linkedList = new CustomLinkedList<int>();
            linkedList.AddFirst(1);
            Assert.Equal(1, linkedList.Count);
            Assert.Null(linkedList.First.Next);
            Assert.Null(linkedList.First.Previous);
            Assert.Null(linkedList.Last.Next);
            Assert.Null(linkedList.Last.Previous);
        }

        [Fact]
        public void AddFirst_MultipleValues_Test()
        {
            var linkedList = new CustomLinkedList<int>();
            linkedList.AddFirst(4);
            linkedList.AddFirst(3);
            linkedList.AddFirst(2);
            linkedList.AddFirst(1);

            Assert.Equal(4, linkedList.Count);
            Assert.Equal(1, linkedList.First!.Value);
            Assert.Equal(2, linkedList.First.Next!.Value);
            Assert.Equal(3, linkedList.First.Next.Next!.Value);
            Assert.Equal(4, linkedList.First.Next.Next!.Next!.Value);
        }

        [Fact]
        public void AddLast_OneValue_Null_Test()
        {
            var linkedList = new CustomLinkedList<int>();
            linkedList.AddLast(1);
            Assert.Equal(1, linkedList.Count);
            Assert.Null(linkedList.First.Next);
            Assert.Null(linkedList.First.Previous);
            Assert.Null(linkedList.Last.Next);
            Assert.Null(linkedList.Last.Previous);
        }

        [Fact]
        public void AddLast_MultipleValues_Test()
        {
            var linkedList = new CustomLinkedList<int>();
            linkedList.AddLast(4);
            linkedList.AddLast(3);
            linkedList.AddLast(2);
            linkedList.AddLast(1);

            Assert.Equal(4, linkedList.Count);
            Assert.Equal(4, linkedList.First!.Value);
            Assert.Equal(3, linkedList.First.Next!.Value);
            Assert.Equal(2, linkedList.First.Next.Next!.Value);
            Assert.Equal(1, linkedList.First.Next.Next!.Next!.Value);
        }

        [Fact]
        public void AddFirst_AddLast_Simultaneously_Test()
        {
            var linkedList = new CustomLinkedList<int>();
            linkedList.AddFirst(2);
            linkedList.AddLast(3);
            linkedList.AddFirst(1);
            linkedList.AddLast(4);

            Assert.Equal(4, linkedList.Count);
            Assert.Equal(1, linkedList.First!.Value);
            Assert.Equal(2, linkedList.First.Next!.Value);
            Assert.Equal(3, linkedList.First.Next.Next!.Value);
            Assert.Equal(4, linkedList.First.Next.Next!.Next!.Value);
        }

        [Fact]
        public void RemoveFirst_Test()
        {
            var linkedList = new CustomLinkedList<int>();
            linkedList.AddFirst(4);
            linkedList.AddFirst(3);
            linkedList.AddFirst(2);
            linkedList.AddFirst(1);
            linkedList.RemoveFirst();

            Assert.Equal(3, linkedList.Count);
            Assert.Equal(2, linkedList.First!.Value);
            Assert.Equal(3, linkedList.First.Next!.Value);
            Assert.Equal(4, linkedList.First.Next.Next!.Value);
            Assert.Null(linkedList.First.Previous);
        }

        [Fact]
        public void RemoveFirst_ShouldThrowError_Test()
        {
            var linkedList = new CustomLinkedList<int>();
            Assert.Throws<InvalidOperationException>(() => linkedList.RemoveFirst());
        }

        [Fact]
        public void RemoveLast_Test()
        {
            var linkedList = new CustomLinkedList<int>();
            linkedList.AddFirst(4);
            linkedList.AddFirst(3);
            linkedList.AddFirst(2);
            linkedList.AddFirst(1);
            linkedList.RemoveLast();

            Assert.Equal(3, linkedList.Count);
            Assert.Equal(1, linkedList.First!.Value);
            Assert.Equal(2, linkedList.First.Next!.Value);
            Assert.Equal(3, linkedList.First.Next.Next!.Value);
            Assert.Null(linkedList.First.Next.Next.Next);
        }

        [Fact]
        public void RemoveLast_ShouldThrowError_Test()
        {
            var linkedList = new CustomLinkedList<int>();
            Assert.Throws<InvalidOperationException>(() => linkedList.RemoveLast());
        }

        [Fact]
        public void ForEach_ShouldMultiplyByTwo_Test()
        {
            var linkedList = new CustomLinkedList<int>();
            linkedList.AddFirst(4);
            linkedList.AddFirst(3);
            linkedList.AddFirst(2);
            linkedList.AddFirst(1);

            linkedList.ForEach(x => x.Value *= 2);

            Assert.Equal(4, linkedList.Count);
            Assert.Equal(2, linkedList.First!.Value);
            Assert.Equal(4, linkedList.First.Next!.Value);
            Assert.Equal(6, linkedList.First.Next.Next!.Value);
            Assert.Equal(8, linkedList.First.Next.Next!.Next!.Value);
        }

        [Fact]
        public void ToArray_ShouldReturnArrayWithCorrectValues_Test()
        {
            var linkedList = new CustomLinkedList<int>();
            linkedList.AddFirst(4);
            linkedList.AddFirst(3);
            linkedList.AddFirst(2);
            linkedList.AddFirst(1);

            var array = linkedList.ToArray();

            Assert.Equal(typeof(int[]), array.GetType());
            Assert.Equal(4, array.Length);
            Assert.Equal(array[0], linkedList.First!.Value);
            Assert.Equal(array[1], linkedList.First.Next!.Value);
            Assert.Equal(array[2], linkedList.First.Next.Next!.Value);
            Assert.Equal(array[3], linkedList.First.Next.Next!.Next!.Value);
        }
    }
}