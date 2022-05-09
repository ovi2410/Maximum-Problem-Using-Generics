namespace FindMaxValue
{
    public class ArrayClassBase
    {
        private IEnumerable<object> inputArray;

        public void ToPrint()
        {
            foreach (var ele in inputArray)
            {
                Console.Write(ele + " ");
            }
        }
    }
}