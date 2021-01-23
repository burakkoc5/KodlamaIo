using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyDictionary<K,V>
    {
        private K[] Keys;
        private V[] Values;

        public MyDictionary()
        {
            Keys = new K[0];
            Values = new V[0];

        }
        public void Add( K keyItem, V valueItem) 
        {
            K[] tempKeys = Keys;
            V[] tempValues = Values;
            Keys = new K[tempKeys.Length + 1];
            Values = new V[tempValues.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                Keys[i] = tempKeys[i];
                Values[i] = tempValues[i];
            }
            

            Keys[Keys.Length - 1] = keyItem;
            Values[Values.Length - 1] = valueItem;
        }


    }
}
