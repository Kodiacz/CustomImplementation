using CustomImplementation;
using System.Collections;

CustomLinkedList<int> list = new CustomLinkedList<int>();

list.AddFirst(30);
list.AddFirst(20);
list.AddFirst(10);
list.AddLast(40);
list.AddLast(50);
list.AddLast(1000);
list.AddFirst(2000);
Console.WriteLine(list.RemoveFirst());
Console.WriteLine(list.RemoveLast());
Console.WriteLine(list.Count);
list.ForEach(x => Console.WriteLine(x.Value));
var arr = list.ToArray();
Console.WriteLine(String.Join("-", arr));

CustomStack<int> test = new CustomStack<int>();
Stack<int> test2 = new Stack<int>();
test.Push(2);
test.Push(1);
Queue queue = new Queue();
