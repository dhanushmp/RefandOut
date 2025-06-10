namespace DiffBetRefandOut
{
    internal class RefandOut
    {

        //If you write a normal method , it will return only one value
        //public int  Math(int a , int b)
        //{
        //    int c = a + b;
        //    int d = a * b;

        //    return c;
        //    return d;     // error- unreachable code detected
        //}

        //If wants to return mutilple vaues, use ref and out 

        public void  Math(int a, int b, ref int c , ref int d)   // a, b - input parameter and c , d -output parameter
        {
             c = a + b;       //if remove logic inside method , it will return value which you are initialized in main method o, p --ref
             d = a * b;
        }

        public void Math2(int a, int b, out int c, out int d)   // a, b - input parameter and c , d -output parameter
        {
            c = a + b;     //If you remove logic inside out , it will throw th error.
            d = a * b;
        }
        static void Main(string[] args)
        {
            int m = 100, n = 20;
            RefandOut obj = new RefandOut();
            int o = 0, p = 0; //To capture output value ,we are declaring two variable o, p -- you must initialize value in ref , orlse it will throw error.

            obj.Math(m, n, ref o, ref p); // ref
            Console.WriteLine(o + " " + p);

            //untill c# 6 , we need to separately initialize the value 
            //From  c# 7 , we no need to intialize the value
            //int q =0 , r = 0; // you no need to  initialize value  
            //int q, r; --- Because value never pass into main method.
            obj.Math2(m, n, out int  q,out int  r); // out
            Console.WriteLine(q +" "+ r);
            
        }
    }
}
