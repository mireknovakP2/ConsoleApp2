namespace ConsoleApp2
{
    internal class Letter : Consignment
    {
        private string v1;
        private string v2;

        public Letter(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public Letter(string v1, string v2, bool v)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}