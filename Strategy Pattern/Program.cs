namespace SpeciesDemoApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Species lion = new Lion();
            lion.Alive();
            lion.Dead();
            

            Species tiger = new Tiger();
            tiger.Alive();
            tiger.Dead();
            

            Species mangoTree = new MangoTree();
            mangoTree.Alive();
            mangoTree.Dead();
            

            Species banyanTree = new BanyanTree();
            banyanTree.Alive();
            banyanTree.Dead();
            

        }
    }
}

