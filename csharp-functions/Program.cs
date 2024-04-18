namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {


            void virgola()
            {
                Console.Write(" , ");
            }



            void StampaArray(int[] array)
            {
                
                Console.Write("[ ");

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                    if (i < array.Length - 1)
                    {
                        virgola();
                    }
                    
                }
                
                Console.Write(" ] ");
            }

            int[] numeri = { 1,2,3,4,5,6,7,8,9 };
            StampaArray(numeri);



            
        }
    }
}
