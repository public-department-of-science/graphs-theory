using System;

namespace DynamicCompile
{
    public class Entry<TK, TP> : IEquatable<Entry<TK, TP>>
    {
        
        public TK Key { get; set; } // ключ

        public TP Pointer { get; set; } // указатель на следующий элемент

        public bool Equals(Entry<TK, TP> other) // реализация метода проверки на эквивалентность (одинаковость двух узлов)
        {
            // если совпали ключи и ссылки на детей. то одинаковые
            return Key.Equals(other.Key) && Pointer.Equals(other.Pointer);
        }
    }
}
