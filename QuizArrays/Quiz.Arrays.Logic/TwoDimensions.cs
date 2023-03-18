namespace Quiz.Arrays.Logic
{
    public class TwoDimensions
    {
        private int[,] _array;

        public int N { get; }
        public int M { get; }

        public TwoDimensions(int _n, int _m)
        {
            N = _n; M = _m;
            _array = new int[_n, _m];
        }
       
        public void Fill()
        {
            var random = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    _array[i, j] = random.Next(1, 100);
                }
            }
        }
        public override string ToString()
        {
            var output = string.Empty;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    output += $"{_array[i, j]}\t";
                }
                output += "\n";
            }
            return output;
        }

        public String ToOneDimension()
        {
            var output = string.Empty;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    output += $"{_array[i, j]}\t";
                }                
            }
            return output;
        }
    
    }
}
