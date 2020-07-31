//static void Main(string[] args)
//{
//    try
//    {
//        var lst = StudentRepository.GetAll();

//        var res = lst.Where(a => a.StudentId == 1);

//        if (res != null)
//        {
//            foreach (var r in res)
//            {
//                Console.WriteLine(r.StudentId);
//            }

//            var x = res.GetEnumerator();
//            //To retrieve all the items from the above IEnumerator object, we cannot use foreach loop instead of that we need to invoke MoveNext() Boolean method.  
//            while (x.MoveNext())
//            {
//                Console.WriteLine(x.Current.StudentId);
//            }
//        }

//        lst.Where(a => a.StudentId == 1).ToList();
//        var minAge = lst.Min(a => a.Age);
//        var maxAge = lst.Max(a => a.Age);
//        var sumAge = lst.Sum(a => a.Age);
//        var avgAge = lst.Average(a => a.Age);


//        Console.WriteLine(minAge);
//        Console.WriteLine(maxAge);
//        Console.WriteLine(sumAge);
//        Console.WriteLine(avgAge);


//        // Distinct
//        Console.WriteLine("--- Distinct and Order By ---");

//        var lstTest1 = new List<string>() { "One", "Two", "One", "Three" };
//        var resultTest1 = lstTest1.Distinct().ToList();

//        //Order By
//        //var resultOrder = lst.OrderByDescending(a => a.StudentId).ToList();
//        var resultOrder = lst.OrderBy(a => a.FirstName).ThenBy(a => a.LastName).ToList();
//        foreach (var item in resultOrder)
//        {
//            Console.WriteLine(item.StudentId + " => " + item.FirstName + " => " + item.LastName);
//        }

//        //All Or Any

//        var boolList = new List<bool> { true, true, true, false };
//        Console.WriteLine("--- Bool LIST ---");
//        var resultA = boolList.All(a => a == true);
//        var resultB = boolList.Any(a => a == true);
//        Console.WriteLine(resultA);
//        Console.WriteLine(resultB);

//        Console.WriteLine("--- Find Index ---");

//        //Find
//        //var resultC = lst.FindIndex(a => a.StudentId == 3);
//        var resultC = lst.FindIndex(a => a.StudentId == 4);
//        Console.WriteLine(resultC);

//        Console.WriteLine("-- DEFAULT IF EMPTY AND ELEMENT AT ---");
//        var emptyList = new List<string>();
//        Console.WriteLine("Count: {0}", emptyList.Count());

//        var newList1 = emptyList.DefaultIfEmpty();
//        Console.WriteLine("Count: {0}", newList1.Count());
//        Console.WriteLine("Value: {0}", newList1.ElementAt(0));


//        var newList2 = emptyList.DefaultIfEmpty("DEFAULT_NONE_VALUE");
//        Console.WriteLine("Count: {0}", newList2.Count());
//        Console.WriteLine("Value: {0}", newList2.ElementAt(0));


//        Console.WriteLine("--------Group By Example -----");
//        var resultGroupBy = lst.GroupBy(a => a.DepartmentId).ToList();

//        foreach (var singleGroup in resultGroupBy)
//        {
//            Console.WriteLine("Department :" + singleGroup.Key);

//            var lstStudent = singleGroup.ToList();

//            Console.WriteLine("ALL STUDENTS");
//            foreach (var item in lstStudent)
//            {
//                Console.WriteLine(item.StudentId + " => " + item.FirstName + " => " + item.LastName);
//            }
//        }


//        Console.WriteLine("--------Inner JOIN Example -----");

//        var deptList = new List<Department>();
//        deptList.Add(new Department
//        {
//            DepartmentId = 1,
//            ShortName = "CE",
//            Name = "Computer Engineering"
//        });
//        deptList.Add(new Department
//        {
//            DepartmentId = 2,
//            ShortName = "EE",
//            Name = "Electrical Engineering"
//        });

//        var studCatList = new List<StudentCategory>();
//        studCatList.Add(new StudentCategory
//        {
//            CategoryId = 1,
//            CategoryName = "Science"
//        });
//        studCatList.Add(new StudentCategory
//        {
//            CategoryId = 2,
//            CategoryName = "Commerence"
//        });
//        studCatList.Add(new StudentCategory
//        {
//            CategoryId = 3,
//            CategoryName = "Arts"
//        });

//        var resulJoin = (from a in lst
//                         join b in deptList on
//                             a.DepartmentId equals b.DepartmentId
//                         join c in studCatList on
//                             a.CategoryId equals c.CategoryId
//                         select new StudentDetails
//                         {
//                             StudentId = a.StudentId,
//                             FirstName = a.FirstName,
//                             LastName = a.LastName,
//                             MiddleName = a.LastName,
//                             DepartmentName = b.Name,
//                             CategoryName = c.CategoryName
//                         }).ToList();


//        foreach (var item in resulJoin)
//        {
//            Console.WriteLine(item.StudentId + " => " + item.FirstName + " => " + item.LastName + " => " + item.DepartmentName + " => " + item.CategoryName);
//        }


//        Console.WriteLine("--- LEft JOin --- ");

//        var resulLeftJoin = (from a in lst
//                             join b in deptList on
//                                 a.DepartmentId equals b.DepartmentId
//                             join c in studCatList on
//                                 a.CategoryId equals c.CategoryId
//                             into z
//                             from d in z.DefaultIfEmpty()
//                             select new StudentDetails
//                             {
//                                 StudentId = a.StudentId,
//                                 FirstName = a.FirstName,
//                                 LastName = a.LastName,
//                                 MiddleName = a.LastName,
//                                 DepartmentName = b.Name,
//                                 CategoryName = d == null ? "" : d.CategoryName
//                             }).ToList();


//        foreach (var item in resulLeftJoin)
//        {
//            Console.WriteLine(item.StudentId + " => " + item.FirstName + " => " + item.LastName + " => " + item.DepartmentName + " => " + item.CategoryName);
//        }



//    }
//    catch (Exception ex)
//    {
//        var sb = new StringBuilder();
//        sb.Append("Message \t" + ex.Message);
//        sb.Append("\n StackTrace \t" + ex.StackTrace);
//        sb.Append("\n InnerException \t" + ex.InnerException);

//        Console.WriteLine(sb.ToString());
//    }

//    Console.ReadLine();
//}