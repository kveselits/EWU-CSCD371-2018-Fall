using System;

namespace Assignment7
{
    /*
     Caveats:
     1. Passing in a null value won't give a warning at compile time,
        so we're forced to deal with the exception somehow. 
     2. Methods accessing _Value can still cause a NullReferenceException.
        So null checks are still necessary when accessing the _Value field.
     */
    public struct NonNullable<T>
    {
        private readonly T _Value;

        public NonNullable(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            _Value = value;
        }

        public T Value
        {
            get
            {
                if (_Value == null)
                {
                    throw new NullReferenceException(nameof(_Value));
                }

                return _Value;
            }
        }
    }
}