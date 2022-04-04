using System;

class MainClass
{
    public static void Main(string[] args)
    {
       
    }
    class Obj
    {
        public int Value;
        public static Obj operator + (Obj a, Obj b) 
        {
            return new Obj 
            {
                Value = a.Value + b.Value 
            };
        }
        public static Obj operator -(Obj a, Obj b)
        {
            return new Obj 
            { 
                Value = a.Value - b.Value 
            };
        }
    }
    class IndexingClass
    {
        private int[] array;

        public IndexingClass(int[] array)
        {
            this.array = array;
        }
        public int this[int index] 
        {
            get 
            {
                if (index >= 0 && index < array.Length)
                {
                    return array[index];
                }
                else 
                {
                    return 0;
                }
            }
            set 
            {
                if (index >= 0 && index < array.Length)
                {
                    array[index] = value;
                }
            }
        }
    }

}

