using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEventsAssignment
{
    internal class LambdaExpression
    {
        public delegate string DelSquareRoot(int a, string b);
        public delegate bool Predicate(XClass x);
        void TryLambda()
        {
            DelSquareRoot delSq = delegate (int a, string b)
            {
                var c = b + DateTime.Now.ToString();
                return $"{c} will have a square root of {Math.Sqrt(a)}.";
            };

            //DelSquareRoot delSqLam = (int a , string b) =>   $"{b} will have a square root of {Math.Sqrt(a)}.";

            Predicate fd = x => (x.LastName == "John" && x.FirstName == "Mark" && x.MiddleName == "Kenneth");

        }


        //var likelyUsername = t.FirstName + "." + t.LastName;
        //var dUserCount = repoUser.WhereOne(x => x.UserName == likelyUsername);


    }

    public class XClass
    {
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
    }

    public class YClass
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }

    public class Callback
    {
        public delegate bool deleg(XClass x);
        public void Call()
        {
            YClass yClass = new YClass();
            yClass.FirstName = "Oluchi";
            yClass.LastName = "Joseph";
            var LikelyUsername = yClass.FirstName + "." + yClass.LastName;

            deleg deleeg = x=> x.UserName == LikelyUsername;
        }
    }
}
