namespace FooBarQix
{
    public class FooBarQixDeterminer
    {
        public string determine(double param)
        {
            string res = "";
            if ((param % 3) == 0)
            {
                res += "foo";
            }
            if ((param % 5) == 0)
            {
                res += "bar";
            }
            if ((param % 7) == 0)
            {
                res += "qix";
            }
            if (res == "")
            {
                res = param.ToString();
            }
            return res;
        }
    }
}