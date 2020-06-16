using System;

namespace genericClass2 {
    class Program
    {
        static void Main(string[] args)
        {
            
            todoList<string> todosOfString = new todoList<string>();
            todosOfString.addTodo("Mandi");
            todosOfString.addTodo("Sarapan");
            todosOfString.addTodo("Kerja");
            todosOfString.addTodo("Makan Siang");
            todosOfString.addTodo("Pulang");
            todosOfString.deleteTodo("Pulang");
            todosOfString.addTodo("Nonton TV");

            todosOfString.printTodo();

        // ! Code By Fillah Firdausyah
        }
    }
}
