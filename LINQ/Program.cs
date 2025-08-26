using static LINQ.ListGenerator;


namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region [LINQ - Restriction Operators] 
            #region Q1
            //var Soldout = ListGenerator.ProductsList.Where(num => num.UnitsInStock == 0);
            //foreach (var item in Soldout)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Q2
            //var Product = ListGenerator.ProductsList.Where(num => num.UnitsInStock > 0 && num.UnitPrice > 3);
            //foreach (var item in Product)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
            

           

            #region [LINQ - Element Operators]
            #region Q1
            //var procuts = ListGenerator.ProductsList.First(P=>P.UnitsInStock==0);
            #endregion
            #region Q2
            //var procuts = ListGenerator.ProductsList.FirstOrDefault(P => P.UnitPrice > 1000);

            #endregion
            #region Q3
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Num = Arr.FirstOrDefault(X => X > 5);
            //var SecNum = Arr.FirstOrDefault(X => X > 5 && X !=Num);

            #endregion
            #endregion

            #region [LINQ - Aggregate Operators]
            //var Array = File.ReadAllText("dictionary_english.txt");
            //var AllWords = Array.Split('\n');
            #region Q1
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var item = Arr.Count(A => A % 2 != 0);
            #endregion
            #region Q2
            //var customerOrderCounts = ListGenerator.CustomersList
            //                  .Select(c => new
            //                  {
            //                      Customer = c,
            //                      OrderCount = c.Orders.Count()
            //                  });

            #endregion
            #region Q3
            //var categoryProductCounts = ListGenerator.ProductsList
            //  .Select(p => new
            //  {
            //      Category = p.Category,
            //      ProductsCount = ListGenerator.ProductsList
            //          .Aggregate(0, (count, product) => count + (product.Category == p.Category ? 1 : 0))
            //  });
            #endregion
            #region Q4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Resualt = Arr.Sum();
            //Console.WriteLine(Resualt);
            #endregion
            #region Q5
            //var TotoalNumOfchars = AllWords.Sum(word =>word.Trim().Length);
            //Console.WriteLine(TotoalNumOfchars);

            #endregion
            #region Q6
            //var SHORTESTWord = AllWords.Min(C => C.Length);
            #endregion
            #region Q7
            //var LongestWord = AllWords.Max(C => C.Length);
            #endregion
            #region Q8
            //var AVGWord = AllWords.Average(C => C.Length);

            #endregion
            #endregion

            #region [LINQ - Ordering Operators ]
            #region Q1
            //var SortbyName = ListGenerator.ProductsList.OrderBy(P => P.ProductName);
            #endregion
            #region Q2
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedArr = Arr.OrderBy(word => word, new CaseInsensitiveComparer());
            #endregion
            #region Q3
            //var Product = ListGenerator.ProductsList.OrderByDescending(X => X.UnitsInStock);
            #endregion
            #region Q4
            // string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            // var SortedArray = Arr.OrderBy(x => x.Length).ThenBy(S=> S);

            #endregion
            #region Q5
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortedArr = Arr.OrderBy(word => word.Length)
            //               .ThenBy(word => word, StringComparer.OrdinalIgnoreCase);

            #endregion
            #region Q6
            //var products = ListGenerator.ProductsList.OrderBy(P => P.Category)
            //                                                                .ThenByDescending(P=>P.UnitPrice);


            #endregion
          
            #endregion

            #region [LINQ – Transformation Operators]
            #region Q1
            //var ProductName = ListGenerator.ProductsList.Select(X => X.ProductName);

            #endregion
            #region Q2
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var WordsVersions = words.Select(words => new { UpperWord = words.ToUpper() , lowerWord = words.ToLower()});


            #endregion
           
            #region Q3
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var Pairs = from A in numbersA
            //           from B in numbersB
            //           where A < B
            //           select new { A, B };
            //foreach (var pair in Pairs)
            //{
            //    Console.WriteLine($"({pair.A} is less than {pair.B})");
            //}
            #endregion
            #region Q4
            //var TotalOrder = ListGenerator.CustomersList.SelectMany(X => X.Orders).Where(o => o.Total < 500.00m) ;
            #endregion
            #region Q7

            //var Orders = ListGenerator.CustomersList.SelectMany(x => x.Orders)
            //                                                        .Where(O => O.OrderDate.Year >= 1998)  ;

            //foreach (var item in Orders)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

        }
    }
    
}
