using System;
using System.Collections.Generic; // Adicione esta diretiva para utilizar a classe Stack

namespace PilhaStack
{
    class Program
    {
        static void Main()
        {
            // Criando uma instância da pilha de strings
            Stack<string> stack = new Stack<string>();

            // Adicionando elementos à pilha
            stack.Push("Item 1");
            stack.Push("Item 2");
            stack.Push("Item 3");

            // Imprimindo a pilha
            Console.WriteLine("Elementos na pilha:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            // Verificando se a pilha está vazia
            Console.WriteLine("A pilha está vazia? " + (stack.Count == 0));

            // Retirando o elemento do topo
            string topItem = stack.Pop();
            Console.WriteLine("Elemento removido do topo: " + topItem);

            // Obtendo o elemento no topo sem removê-lo
            string peekItem = stack.Peek();
            Console.WriteLine("Elemento no topo (sem removê-lo): " + peekItem);

            // Imprimindo a pilha novamente
            Console.WriteLine("Elementos na pilha após a remoção:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            // Verificando se a pilha está vazia novamente
            Console.WriteLine("A pilha está vazia? " + (stack.Count == 0));
        }
    }
}
