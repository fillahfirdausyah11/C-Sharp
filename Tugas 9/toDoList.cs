using System;
using System.Collections.Generic;

namespace genericClass2 {

    public class todoList <T> {

        private List<T> todos;
        public todoList() {
            this.todos  = new  List<T>();
        }
        public void addTodo(T newTodos) {
            todos.Add(newTodos);
        }
        public void deleteTodo(T todoToRemove) {
            todos.Remove(todoToRemove);
        }
        public void printTodo() {
            foreach(var todo in todos) {
                Console.WriteLine(todo.ToString());
            }
        }
    }
    // ! Code By Fillah Firdausyah
}