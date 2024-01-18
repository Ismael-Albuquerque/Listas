using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course {

    class Program { 
            static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            //adicionar o indice e depois o valor, nesse caso adicionamos o Marcos na posicao 2
            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);

            }
            //lendo a quantidade de itens na lista
            Console.WriteLine("List count: " + list.Count);

            //função FIND para encontrar o item específico, nesse caso com a letra A
                                  //(utilizando) função LAMBDA
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            //encontrar a 1 ou ultima posição de elemento da lista
            int pos1 = list.FindIndex(x => x[0] ==  'A');
            Console.WriteLine("First position 'A': " + pos1);

            //achar a posição doúltimo elemento que começa com a letra 'A'
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            //filtrar a lista com base no predicado,
            //nesse caso os nomes que tem 5 caracteres
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("----------------------------------");
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }
            //remover elementos da lista,
            //nesse  exemplo remover o nome Alex da lista
            list.Remove("Alex");
            Console.WriteLine("----------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //remover o elemento pela posição dele
            list.RemoveAt(1);
            Console.WriteLine("----------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //remover os elementos de uma faixa
            list.RemoveRange(1, 1);
            Console.WriteLine("----------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //remover todos os nomes que começam com a letra 'M'
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("----------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }                       
            
        }   
    
    }

}

