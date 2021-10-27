using System;
using System.Collections.Generic;

namespace ExemploListas
{
    class Program
    {
        //RAFAEL DO NASCIMENTO RODRIGUES RA 210211
        static void Main(string[] args)
        {
            //Fazendo a lista de strings
            List<string> list = new List<string>();
            
            //Adicionando as strings na lista
            list.Add("Fábio");
            list.Add("Wilson");
            list.Add("Angelina");
            list.Add("Eliney");
            list.Add("André");
            //Adicionando string na posição sugerida (no caso a "2")
            list.Insert(2, "Lucas");
            
            //Utilizando o foreach para passar por todos os elementos da lista
            foreach(string obj in list)
            {
                //Escrever na tela todos os nomes na lista
                Console.WriteLine(obj);
                
            }

            //Escrever na tela a quantidade de elementos na lista com o list.Count
            Console.WriteLine("Quantidade de elementos na lista: " + list.Count);
            //Achar o primeiro elemento da lista que começa com a letra A
            string s1 = list.Find(x => x[0] == 'A');
            //Escrever na tela o primeiro elemento da lista que começa com a letra A
            Console.WriteLine("Primeiro elemento que começa com a letra 'A': " + s1);
            //Achar o último elemento da lista que começa com a letra A
            string s2 = list.FindLast(x => x[0] == 'A');
            //Escrever na tela o último elemento da lista que começa com a letra A
            Console.WriteLine("Ultimo elemento que começa com a letra 'A': " + s2);

            //Buscar elementos na lista por sua posição (primeiro)
            int pos1 = list.FindIndex(x => x[0] == 'A');
            //Escrever na tela a primeira posição de A (Nome na lista que começa com A)
            Console.WriteLine("Primeira posição de 'A': " + pos1);
            //Buscar elementos na lista por sua posição (último)
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            //Escrever na tela a última posição de A (Nome na lista que começa com A)
            Console.WriteLine("A última posição de 'A': " + pos2);

            //Buscar todos os elementos na lista com tamanho igual a 5 caracteres
            List<string> list2 = list.FindAll(x => x.Length == 5);
            //Apenas para separar
            Console.WriteLine("-------------------------------");
            //Utilizando o foreach para passar por todos os elementos da lista
            foreach (string obj in list2)
            {
                //Escrever na tela todos os nomes na lista com tamanho igual a 5
                Console.WriteLine(obj);
            }

            //Remoção de elementos da lista (nesse caso a string "André")
            list.Remove("André");
            //Apenas para separar
            Console.WriteLine("===================");
            //Utilizando o foreach para passar por todos os elementos da lista
            foreach (string obj in list)
            {
                //Escrever na tela todos os nomes na lista (sem a string "André")
                Console.WriteLine(obj);
            }

            //Remover todos os elementos que começam com "W")
            list.RemoveAll(x => x[0] == 'W');
            //Apenas para separar
            Console.WriteLine("+++++++++++++++++++");
            //Utilizando o foreach para passar por todos os elementos da lista
            foreach (string obj in list)
            {
                //Escrever na tela todos os nomes na lista (tirando os elementos que começam com W)
                Console.WriteLine(obj);
            }

            //Remover o elemento de determinada posição da lista (posição 3)
            list.RemoveAt(3);
            //Apenas para separar
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");
            //Utilizando o foreach para passar por todos os elementos da lista
            foreach (string obj in list)
            {
                //Escrever na tela todos os nomes na lista (exceto o 3 que foi removido)
                Console.WriteLine(obj);
            }

            //Remover os elementos da lista em determinadas posições (nesse caso o 1 e o 2)
            list.RemoveRange(1, 2);
            //Apenas para separar
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");
            //Utilizando o foreach para passar por todos os elementos da lista
            foreach (string obj in list)
            {
                //Escrever na tela todos os nomes na lista (exceto o 1 e o 2 que foram removidos)
                Console.WriteLine(obj);
            }
        }
    }
}
