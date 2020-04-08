using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11
{
    public class GoodSet
    {
        private int[] set; // поле для хранения данных
        private int n; // поле для хранения размера

        public GoodSet(int n_)
        {
            this.set = new int[n]; // инициализируем матрицу
            this.n = set.Length;
            this.set = StandSet(set);
        }

        public GoodSet(int[] set)
        {
            this.set = StandSet(set);
            this.n = set.Length;
        }

        public GoodSet(string srt)
        {
            this.set = StandSet(TextToMatrix(srt));
            this.n = set.Length;
        }

        // индексатор
        public int this[int i]
        {
            get
            {
                return set[i];
            }
            set
            {
                set[i] = value;
            }
        }

        // возвращаем различающиеся элементы и созд массив
        private int[] StandSet(int[] set)
        {
            return set.Distinct().ToArray();
        }

        // преобразуем текст в матрицу
        private int[] TextToMatrix(string str)
        {
            // разделим строку на элементы
            string[] element = str.Split(' ');
            // узнаем количество элементов
            var numEl = element.Length;

            // преобразуем в матрицу
            var matrix = new int[numEl];
            for (var i = 0; i < element.Length; ++i)
            {
                matrix[i] = int.Parse(element[i]);
            }
            return matrix;
        }

        // преобразуем матрицу в текст
        public string MatrixToString()
        {
            string str = "";
            for (int i = 0; i < this.Size; i++)
            {
                if (i == this.Size - 1)
                {
                    str += set[i].ToString();
                }
                else
                {
                    str += set[i] + " ";
                }
            }
            return str;
        }


        // объединение двух множеств
        public static GoodSet operator +(GoodSet setFirst, GoodSet setSecond)
        {
            var items = new List<int>();

            items.AddRange(setFirst.Array); // добавим в items элементы из указаного массива
            for (int i = 0; i < setSecond.Size; i++)
            {
                // проверим, чтобы числа в массиве не повторялись
                if (!items.Contains(setSecond[i]))
                {
                    items.Add(setSecond[i]);
                }
            }

            var result = new GoodSet(items.ToArray<int>());
            return result;
        }

        // пересечение двух множеств
        public static GoodSet operator *(GoodSet setFirst, GoodSet setSecond)
        {
            var items = new List<int>();

            for (int i = 0; i < setFirst.Size; i++)
            {
                for (int j = 0; j < setSecond.Size; j++)
                {
                    // если число есть в обоих массивах и мы его еще не получали, то добавляем
                    if (setFirst[i] == setSecond[j] && !items.Contains(setFirst[i]))
                    {
                        items.Add(setFirst[i]);
                    }
                }
            }

            var result = new GoodSet(items.ToArray<int>());
            return result;
        }

        // разность двух множеств
        public static GoodSet operator -(GoodSet setFirst, GoodSet setSecond)
        {
            var items = new List<int>();

            items.AddRange(setFirst.Array); // добавим в items элементы из указаного массива
            for (int i = 0; i < setSecond.Size; i++)
            {
                // удаляем
                items.Remove(setSecond[i]);
            }

            var result = new GoodSet(items.ToArray<int>());
            return result;
        }

        // добавление элемента к множеству
        public static GoodSet operator +(GoodSet setFirst, int num)
        {
            var items = new List<int>();

            items.AddRange(setFirst.Array); // добавим в items элементы из указаного массива

            // если число не содержится в массиве, то добавляем
            if (!items.Contains(num))
            {
                items.Add(num);
            }

            var result = new GoodSet(items.ToArray<int>());
            return result;
        }

        public static GoodSet operator +(int num, GoodSet setFirst)
        {
            return setFirst + num;
        }

        // удаление элемента из множества
        public static GoodSet operator -(GoodSet setFirst, int num)
        {
            var items = new List<int>();

            items.AddRange(setFirst.Array); // добавим в items элементы из указаного массива

            // если число содержится в массиве, то удаляем
            if (items.Contains(num))
            {
                items.Remove(num);
            }

            var result = new GoodSet(items.ToArray<int>());
            return result;
        }

        public static GoodSet operator -(int num, GoodSet setFirst)
        {
            return setFirst - num;
        }



        // свойство которое возвращает количество элементов в матрице
        public int Size
        {
            get
            {
                return n;
            }
        }

        // свойство которое возвращает элемент в матрице
        public int[] Array
        {
            get
            {
                return set;
            }
        }

        // метод Equals для сравнения с любым объектом
        public override bool Equals(object obj)
        {
            // преобразовываем переданный объект в множество
            var B = obj as GoodSet;

            // если преобразование не удалось, то в B окажется null
            if (B == null)
                return false; // а если не множество, то значит не совпадает, возвращаем false

            // если B оказалось множеством поэлементно сравниваем элементы
            for (var i = 0; i < this.Size; ++i)
            {
                //  ищем первый несовпавший элемент
                if (this[i] != B[i])
                    return false; // если найдем, значит не совпадают
            }
            return true; // если не найдем, значит совпадает, возвращает true
        }
    }
}
