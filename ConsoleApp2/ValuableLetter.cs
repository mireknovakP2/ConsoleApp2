﻿namespace ConsoleApp2
{
    internal class ValuableLetter : Consignment
    {
        private string v1;
        private string v2;
        private int v3;

        public ValuableLetter(string v1, string v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public ValuableLetter(string v1, string v2, int v3, bool v)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }
    }
}