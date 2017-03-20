
namespace CSharpSeven.LocalFunctions
{
    public class Bubblesort
    {
        private readonly int[] _array;

        public Bubblesort(int[] array) =>  _array = array;

        public void Sort()
        {
            for (var i = _array.Length - 1; i > 0; i--)
                for (var j = i; j < _array.Length; j++)
                    if (_array[j] > _array[i])
                        Swap(i, j);

            void Swap(int i, int j)
            {
                var temp = _array[i];
                _array[i] = _array[j];
                _array[j] = temp;
            }
        }
    }
}
