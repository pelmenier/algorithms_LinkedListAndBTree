using System;
using System.Collections.Generic;
using System.Text;

namespace Alg.Model
{
    public class Item<T>
    {
        /// <summary>
        /// Данные хранимые в ячейке односвязного списка.
        /// </summary>
        private T data = default(T);
        public Item<T> Next { get; set; }

        public int IndexItem { get; set; }

        public T Data
        {
            get { return data; }
            set
            {
                if (value != null)
                    data = value;
            }
        }  
        
        public Item(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
