using static LINQ.ListGenerator;


namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Dynamic function
            //public static dynamic method(dynamic name) { }
            #endregion
            
            
                #region Var - Dynamic
                //// implicitly typed local variables 

                //// var --> compiler can detect the Datatype based on the initial value

                //// var Data01; Syntax error the var must have initial value  
                //var Data01 = "string";

                //// Can't be null aswell coz that's not initial value
                //// Data01 = 12;
                //// invalid coz it should be string coz the inital value was string
                //// can't use var as a parameter or a return type

                //// dynamic Like var in JS

                //dynamic d = "kiro";
                //// CLR detect datatype of the local variable based on last value 
                //d = 12;
                //Console.WriteLine(d.GetType().Name);
                //d = 12.2f;
                //Console.WriteLine(d.GetType().Name);
                //// dont need to be initialized 
                //// can be null during initialization
                //// Can hold data from anytype 
                //// get the datatype during runtime 
                //// can use dynamic as a parameter or return type 
                //// change the datatype after iniatialization


                //// when to use var or dynamic 
                //// when you want to relase the headache from choosing the right datatype
                #endregion

                #region Anonymous method

                //// Type that doesnt have a name 
                //// if you have a data on employee but only name and id for example
                //// you dont need to get the password from the database 

                //var Anon = new { Id = 1, Name = "Name", Salary = 120000.0m };
                ////var Anon02 = new { Id = 2, Name = "Name", Salary = 120000.0m };
                //// Same type as same names of the attributes and order 
                ////Console.WriteLine(Anon.Id);
                ////Console.WriteLine(Anon.Name);
                ////Console.WriteLine(Anon.Salary);

                //////Anon.Id = 3; // Can't change it's value after creation 
                ////Console.WriteLine(Anon.GetType().Name);


                ////Console.WriteLine(Anon.GetHashCode());
                ////Console.WriteLine(Anon02.GetHashCode());

                ////if (Anon.Equals(Anon02))
                ////{
                ////    Console.WriteLine("Equals");
                ////}
                //// complier will override on tostring and equals and getHashcode

                //var Anon03 = Anon with { Id = 10};
                //// what if i want to copy the values except the id
                //// for example i want to override the value of the id 
                //// in C# 10.0
                //Console.WriteLine(Anon03);


                #endregion

                #region Extention Method
                //int Number = 12345; 
                //// if you want to reverse it you won't be able to
                //// coz there is no func that do that 
                //Console.WriteLine(IntExtention.Reverse(Number));
                ////Number.Reverse(); Target    
                //Console.WriteLine(Number.Reverse());

                #endregion

                #region LINQ introduction
                //// Language integrated query 
                ////          : 40+ extention methods (LINQ operators)
                ////          : [anydata that are in secquance]
                ////          : 13 Category
                ////          : LINQ operators exists in the class called "Enumerable"

                //// what is sequence --> object from class implements interface called "IEnumerable"
                //// Local sequence  : Local data we call it L2O , L2XML
                //// Remote sequence : L2EF

                //// Input Sequence --> LINQ operator --> Output Sequence 
                //// Input Sequence --> LINQ operator --> One value
                ////                --> LINQ operator --> Output Sequence 

                //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                ////var Answer = Enumerable.Where(list, N => N % 2 == 0);

                ////foreach (var item in Answer) 
                ////{
                ////    Console.Write($"{item} ");
                ////}
                //bool Answer = Enumerable.Any(list, N => N % 2 == 0);

                //Console.WriteLine(Answer);

                //var result = Enumerable.Range(0, 100);
                //foreach (int i in result) 
                //{
                //    Console.WriteLine(i);
                //}

                #endregion

                #region LINQ Syntax

                ////// 1. Fluent Suntax
                ////// user LINQ methods 

                ////// 1.1 LINQ AS a class member method --> from "Enumbrable"
                //////List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
                //////List<int> list2= Enumerable.Where(list, N => N % 2 == 0).ToList();

                //////foreach (int i in list2)
                //////{
                //////    Console.WriteLine(i);
                //////}

                ////// 1.2 as a extention method
                ////List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
                ////List<int> answer = list.Where(x => x % 2 == 0).ToList();

                ////foreach (int i in answer)
                ////{
                ////    Console.WriteLine(i);
                ////}

                //// 2. Query Suntax Like SQL Style easier when there is join or group by or let 
                //// start by from 
                //// end with group by or select 

                //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
                //var answer = from N in list
                //             where N % 2 == 0
                //             select N;

                //foreach (int i in answer)
                //{
                //    Console.WriteLine(i);
                //}


                #endregion

                #region Execution Ways

                //// Linq execution ways 
                //// 1. Differed Execution way  : 10 Category 
                //// 2. Immediate Execution way : 3 Category [ Elements operator - Casting operator - aggregate operator ]

                ////List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                ////var ans = nums.Where(N => N % 2 == 0);
                ////nums.AddRange([11, 10, 12]);

                ////foreach (int n in ans) // the where happens here only when called
                ////{
                ////    Console.WriteLine(n);
                ////}

                //List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                //var ans = nums.Where(N => N % 2 == 0).ToList(); // works immeidate so the where will work aswell 
                //nums.AddRange([11, 10, 12]);

                //foreach (int n in ans) // the where happens here only when called
                //{
                //    Console.WriteLine(n);
                //} 
                #endregion

                #region Data Setup
                //////// Setup data
                //////Console.WriteLine(ListGenerator.CustomerList[0]); 

                //var result = ProductList.Where(N => N.UnitsInStock == 0);
                //foreach (var item in result)
                //{
                //    Console.WriteLine(item);
                //}
                #endregion

            }
        
        //////// Implicity typed local variable
        //////// int x = 12;
        //////// var - dynamic
        ////// var x = 12;
        //////// --> automatic detection based on the initial value 
        //////// can't be null , cant change type 

        ////// dynamic y = 12;
        //////// clr detect type based on last value 
        //////// Like var in javascript 
        //////// don't use dynamic just in case 

        ////// anonymous type 
        ////// if data is from the database 
        ////// use anonymous type 

        ////// Extention method should be static class member method

        ////// LINQ 40 Extenstion methods 

        ////Console.WriteLine(ListGenerators.ProductList[0]);
        //Console.WriteLine(CustomerList[0]);


        #region Filtration operator

        // Linq 40+ methods 
        // 13 category 

        // Filteration operators
        // where / Oftype

        // Fluent syntax 
        //var result = ProductList.Where(x => x.UnitsInStock == 0);
        //foreach (var unit in result) 
        //{
        //    Console.WriteLine(unit);
        //}

        //var result2 = from x in ProductList
        //              where x.UnitsInStock == 0
        //              select x;

        ////var result = ProductList.Where(C => C.Category == "Meat/Poultry").Where(C => C.UnitsInStock > 0);
        //var result = ProductList.Where(C => C.Category == "Meat/Poultry" && C.UnitsInStock > 0);

        //var result = from C in ProductList
        //             where C.Category == "Meat/Poultry" && C.UnitsInStock > 0
        //             select C;

        // Get top 10 in the product list using indexes
        //var result = ProductList.Where((P, index) => index < 10 && P.UnitsInStock > 0);
        // will get less than index it searchs only in the top 10
        // what if you want to get top 10 regardless

        //var result = ProductList.Where(P => P.UnitsInStock > 0).Where((P, index) => index < 5);

        //foreach (var unit in result)
        //{
        //    Console.WriteLine(unit);
        //}

        //ArrayList Arr = new ArrayList() { 1 , 2 , "Ahmed" , 'C' , 1.3 , ProductList[0] };

        //var result = Arr.OfType<Product>();
        //foreach (var unit in result)
        //{
        //    Console.WriteLine(unit);
        //} 
        #endregion

        #region Transformation operators 

        //// Transformation operators 
        //// Select / SelectMany

        ////var result = ProductList.Select(C => C.ProductName);

        ////var result = from P in ProductList
        ////             select P.ProductName;

        ////var result = ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Seafood")
        ////                        .Select(P => new {
        ////                            Name = P.ProductName ,
        ////                            Category = P.Category ,
        ////                            OldPrice = P.UnitPrice ,
        ////                            NewPrice = P.UnitPrice - P.UnitPrice * 0.1m 
        ////                        });

        ////var result = from P in ProductList
        ////             where P.UnitsInStock > 0 && P.Category == "Seafood"
        ////             select new {
        ////                 Name = P.ProductName, 
        ////                 Category = P.Category,
        ////                 OldPrice = P.UnitPrice,
        ////                 NewPrice = P.UnitPrice - P.UnitPrice * 0.1M,
        ////             };

        ////var result = CustomerList.SelectMany(c => c.Orders);

        ////var result = from C in CustomerList
        ////             from O in C.Orders
        ////             select O;

        //var result = ProductList.Select((P, I) => new { I, P.ProductName }).Where(P => P.I < 5); 

        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region Ordering operators
        // Ordering operators
        // Sorting 

        //var result = ProductList.OrderBy(P => P.UnitPrice)
        //                        .Select(P => new {
        //                            P.ProductName ,
        //                            P.UnitPrice
        //                        });

        //var result = ProductList.OrderByDescending(P => P.UnitsInStock)
        //                        .ThenBy(P => P.UnitPrice) // then by is ascending
        //                        .Select(P => new
        //                        {
        //                            P.ProductName,
        //                            P.UnitPrice
        //                        });

        //var result = ProductList.OrderByDescending(P => P.UnitsInStock)
        //                        .ThenByDescending(P => P.UnitPrice) // then by is ascending
        //                         .Select(P => new
        //                         {
        //                             P.ProductName,
        //                             P.UnitsInStock,
        //                             P.UnitPrice
        //                         });

        //var result = ProductList.Where(P => P.Category == "Seafood")
        //                        .OrderByDescending(P => P.UnitsInStock)
        //                        .ThenByDescending(P => P.UnitPrice) // then by is ascending
        //                        .Select(P => new
        //                        {
        //                            P.ProductName,
        //                            P.UnitsInStock,
        //                            P.UnitPrice ,
        //                            P.Category
        //                        });

        //var result = from P in ProductList
        //             where P.Category == "Meat/Poultry" && P.UnitsInStock > 0
        //             orderby P.UnitsInStock, P.UnitPrice ascending
        //             select new {
        //                 P.ProductName,
        //                 P.UnitsInStock,
        //                 P.UnitPrice,
        //                 P.Category
        //             };

        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //} 
        #endregion

        #region Elements operators

        ////// Elements operators --> immediate Execution one element in return 

        ////////var result = ProductList.First(); // May throw execption [Sequance has no elements]
        ////////result = ProductList.Last();

        ////////var result = ProductList.First(P => P.UnitsInStock == 0);

        //////var result = ProductList.FirstOrDefault(P => P.UnitsInStock == 100000,
        //////                                    new Product() { ProductName = "Default product"}); 
        //////// returns a default value if the matching condition wasn't found

        //////Console.WriteLine(result.ProductName);

        //////var result = ProductList.ElementAtOrDefault(13232);

        //////result = ProductList.ElementAtOrDefault(0);

        //////var result = ProductList.Single(); // if the list contains only one element

        //////ProductList = new List<Product>() { new Product() { ProductName = "Test One Product" } };
        ////ProductList = new List<Product>() { }; // Returns null if the ssequance is empty 

        //////var result = ProductList.Single(P => P.UnitsInStock == 0); // if the list contains only one element


        ////var result = ProductList.SingleOrDefault(new Product() { ProductName = "Default "});

        ////result = ProductList.SingleOrDefault(P => P.UnitsInStock == 0);

        ////Console.WriteLine(result); 

        //var result = ProductList.DefaultIfEmpty();

        //foreach (var item in result) 
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region Aggregate operators

        //// Aggregate operators --> immedate execution

        //////// Count - sum - max - min - avg 

        //////////var result = ProductList.Count();
        //////////Console.WriteLine(result);

        //////////var result = ProductList.Count(P => P.UnitPrice < 70);

        //////////var result = ProductList.Sum(P => P.UnitPrice);

        //////////var result = ProductList.Average(P => P.UnitPrice);

        ////////var result = ProductList.Max();
        //////////var result = ProductList.Max(new ProductComparerUnitInStock());

        ////////var result = ProductList.MaxBy(P => P.UnitPrice);

        ////////var result = ProductList.Min(P => P.UnitPrice);
        //////var result = ProductList.MinBy(P => P.UnitPrice);

        //List<string> list = new List<string>() { "Ahmed" , "Ali" , "Omer"};
        //var result = list.Aggregate((S01 , S02) => $"{S01 + S02}");

        //Console.WriteLine(result);

        #endregion

        #region Casting operators

        //// Casting operators 

        //List<Product> List = ProductList.Where(P => P.UnitsInStock == 0).ToList();
        //Product[] list = ProductList.Where(P => P.UnitsInStock == 0).ToArray();
        //Dictionary<long , Product> dict = ProductList.Where(P => P.UnitsInStock == 0).ToDictionary(P => P.ProductID);

        //foreach (Product Product in List) 
        //{
        //    Console.WriteLine(Product);
        //} 
        #endregion

        #region Genration operators

        //// Genration operators
        //// only used as a class memeber method "Enumrable"

        //// Range , Empty , Repeat

        ////var result = Enumerable.Range(1, 100);

        ////var result = Enumerable.Empty<Product>();

        //var result = Enumerable.Repeat(ProductList[0], 3);

        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //} 
        #endregion

        #region Set operators 
        //// Set operators 
        //// Union - Union all - intersect - Execpt

        //var Seq01 = Enumerable.Range(1, 100);
        //var Seq02 = Enumerable.Range(50, 100);

        ////var result = Seq01.Union(Seq02);

        ////var result = Seq01.Concat(Seq02);

        ////result = result.Distinct();

        ////var result = Seq01.Intersect(Seq02);

        //var result = Seq01.Except(Seq02);

        //foreach (var item in result)
        //{
        //    Console.Write($"{item} ");
        //} 
        #endregion

        #region Quantifiers operators

        //// Quantifiers operators
        //// Any - All - SequanceEqual - Contains

        //var seq01 = Enumerable.Range(1, 100);
        //var seq02 = Enumerable.Range(50, 100);

        ////// Any() --> return trueif there is at least one element in the sequance
        //////var result = seq01.Any(n => n % 2 == 0);

        ////var result = seq01.All(n => n > 0); // true if was empty or all the elements match the condition

        ////var result = seq01.SequenceEqual(seq02); // true if the two sequance are the same 

        //var result = seq02.Contains(1);

        //Console.WriteLine(result); 
        #endregion

        #region Zipping operators

        //// Zipping operator 
        //// Zip
        //List<string> Words = new List<string>() { "ten", "Twinty", "Thirty", "fourty" };
        //List<int> Numbers = new List<int>() { 10, 20, 30, 40, 50, 60 };

        //var answer = Words.Zip(Numbers, (W, N) => $"{N} --> {W}");

        //foreach (var i in answer)
        //{
        //    Console.WriteLine(i);
        //} 
        #endregion

        #region Grouping operators

        //// Grouping operator 
        //// like group in sql

        ////var result = ProductList.GroupBy(P => P.Category);
        ////foreach (var item in result) 
        ////{
        ////    Console.WriteLine($"{item.Key}");
        ////    foreach (var item2 in item) 
        ////    {
        ////        Console.WriteLine(item2);
        ////    }
        ////}

        //var result = from p in ProductList
        //             where p.UnitsInStock > 0
        //             group p by p.Category
        //             into Cat where Cat.Count() > 10
        //             select Cat;


        //foreach (var item in result)
        //{
        //    Console.WriteLine($"{item.Key}");
        //    foreach (var item2 in item)
        //    {
        //        Console.WriteLine(item2);
        //    }
        //} 
        #endregion

        #region Partitioning operators

        //// Partitioning operators
        ////// Take , Takelast , skip , skiplast , Takewhile , skipwhile

        ////////var result = ProductList.Where(P => P.UnitsInStock == 0).Take(5); // first 5 from the start
        //////var result = ProductList.TakeLast(5); // take 5 from end

        //////var result = ProductList.Skip(10).Take(3); // skip first 10
        ////var result = ProductList.SkipLast(10); // skip first 10

        //int[] nums = { 9, 18, 1, 2, 6, 7 };
        ////var result = nums.TakeWhile(n => n % 3  == 0);
        ////var result = nums.SkipWhile(n => n % 3 == 0);
        //var result = nums.TakeWhile((N , I) => N > I);


        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //} 
        #endregion

        #region let , into

        //// let , into
        //// a e o i u A E O I U
        //List<string> list = new List<string>() { "Ahmed" , "Ali" , "youssef" , "Aya" , "Mona" , "Saly" , "osama"};
        ////var result = Regex.Replace("Ahmed", "[aeoiuAEOIU]", string.Empty);
        ////Console.WriteLine(result);

        ////var result = from N in list 
        ////             select Regex.Replace(N, "[aeoiuAEOIU]", string.Empty)
        ////             into seq where seq.Length > 3
        ////             select seq;

        //var result = from N in list
        //             let seq = Regex.Replace(N, "[aeoiuAEOIU]", string.Empty)
        //             where seq.Length > 3
        //             select seq;

        //foreach (var item in result) 
        //{
        //    Console.WriteLine(item);
        //} 
        #endregion
    }
    }
    

