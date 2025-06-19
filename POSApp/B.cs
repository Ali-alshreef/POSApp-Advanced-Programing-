namespace POSApp
{
    public class B : A
    {
        public override void Print()
        {
         //  base.Print();
            int y = this.Counter ;
            Console.WriteLine("Print B");
        }
    }
}
