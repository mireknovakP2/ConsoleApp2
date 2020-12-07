namespace ConsoleApp2
{
    internal class Postcard : Consignment
    {
        private string v1;
        private string v2;

        public Postcard(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}