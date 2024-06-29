using Assignment3;

MyStack<int> stack = new MyStack<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);
Console.WriteLine("Stack Count: " + stack.Count()); 
Console.WriteLine("Pop from Stack: " + stack.Pop()); 
Console.WriteLine("Stack Count after Pop: " + stack.Count()); 


MyList<string> list = new MyList<string>();
list.Add("a");
list.Add("b");
list.Add("c");
Console.WriteLine("List contains 'b': " + list.Contains("b")); 
Console.WriteLine("Remove element at index 1: " + list.Remove(1)); 
list.InsertAt("d", 1);
Console.WriteLine("Element at index 1 after InsertAt: " + list.Find(1)); 
list.DeleteAt(1);
Console.WriteLine("Element at index 1 after DeleteAt: " + list.Find(1));
list.Clear();
Console.WriteLine("List Count after Clear: " + list._list.Count);



