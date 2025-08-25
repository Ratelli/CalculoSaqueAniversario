using System.Collections.Generic;
public class ListaGenerica<T>
{
    public T[] _itens;
    //contador para conseguir buscar na lista (o primeiro item começa em zero)
    public int _contador;

    public ListaGenerica(int capacidade) //Construtor com o tamanho máximo da lista
    {
        _itens = new T[capacidade];
        _contador = 0;
    }

    // Adicionar item no final
    public void Adicionar(T item)
    {
        _itens[_contador] = item;
        _contador++;
    }

    // Ler item, precisa ter um item válido
    public T Ler(int indice)
    {
        return _itens[indice];
    }

    public void RemoveAt(int indice)
    {
        for (int i = indice; i < _contador - 1; i++)
        {
            _itens[i] = _itens[i + 1]; // "empurra" os elementos para a esquerda
        }

        _contador--;
    }
}