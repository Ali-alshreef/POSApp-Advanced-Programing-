namespace POSApp
{
    public class A
    {
        public int Counter { get; set; } = 0;
        public virtual void  Print()
        {
            Counter = 5;
            Console.WriteLine("Print A");
        }
    }
}
