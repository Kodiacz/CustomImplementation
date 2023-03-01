namespace CustomImplementation.Test
{
    public class CustomStackTest
    {
        [Fact]
        public void Push_Test()
        {
            CustomStack<int> stack = new CustomStack<int>();

            stack.Push(1);

            Assert.Equal(1, stack.Count);
        }

        [Fact]
        public void Pop_Test()
        {
            CustomStack<int> stack = new CustomStack<int>();

            stack.Push(1);

            var value = stack.Pop();

            Assert.Equal(1, value);
        }

        [Fact]
        public void Pop_Should_Throw_InvalidOperationException_Test()
        {
            CustomStack<int> stack = new CustomStack<int>();
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Fact]
        public void Pop_With_Multiple_Values_Test()
        {
            CustomStack<int> stack = new CustomStack<int>();

            stack.Push(2);
            stack.Push(3);
            stack.Push(1);

            Assert.Equal(1, stack.Pop());
            Assert.Equal(2, stack.Count);
        }

        [Fact]
        public void Peek_Test()
        {
            CustomStack<int> stack = new CustomStack<int>();

            stack.Push(1);

            Assert.Equal(1, stack.Peek());
            Assert.Equal(1, stack.Count);
        }

        [Fact]
        public void Peek_With_Multiple_Values_Test()
        {
            CustomStack<int> stack = new CustomStack<int>();

            stack.Push(2);
            stack.Push(3);
            stack.Push(1);

            Assert.Equal(1, stack.Peek());
            Assert.Equal(3, stack.Count);
        }

        [Fact]
        public void Peek_Should_Throw_ArgumentNullException_Test()
        {
            CustomStack<int> stack = new CustomStack<int>();
            Assert.Throws<ArgumentNullException>(() => stack.Peek());
        }

        [Fact]
        public void Contains_Should_Return_True_Test()
        {
            CustomStack<int> stack = new CustomStack<int>();

            stack.Push(2);

            Assert.True(stack.Contains(2));
        }

        [Fact]
        public void Contains_Should_Return_False_Test()
        {
            CustomStack<int> stack = new CustomStack<int>();

            stack.Push(2);

            Assert.False(stack.Contains(3));
        }
    }
}
