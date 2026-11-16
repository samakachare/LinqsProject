using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Linqproject
{
    internal class Program
    {
        //LINQ (Language Integrated Query) is a C# feature used to query and manipulate data from collections such as List<T>, arrays, dictionaries, and databases.
        //Without LINQ, you often need foreach loops:
        static void Main(string[] args)
        {
            //    List<int> numbers = new List<int> {10,20,30,40,50,60,70};
            //    var result = numbers.Where(x => x > 20); // where() is used to filter element according to a condition.
            //    foreach (int number in result)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}


            //    List<int> nums = new List<int> { 11, 12, 13, 14 };
            //    var results = nums.Where(x => x > 10);
            //    foreach(int numbers in results)
            //    {
            //        Console.WriteLine(numbers);
            //    }


            // Select => is used to select and transform the elements
            // var is a keyword used to implicitly declear a variable, the compiler automatically determines the variables data type from the assigned to it.

            //List<int> sel = new List<int> { 10, 22, 33, 44, 55 };
            //var result = sel.Select(x => x * 2);
            //foreach(var sum in result)
            //{
            //    Console.WriteLine(sum);
            //}

            // orderBy() -> used for ascending sorting .

            //List<int> orders = new List<int> { 10, 5, 34, 12, 32, 13 };
            //var result = orders.OrderBy(x => x);
            //foreach (var or in result)
            //{
            //    Console.WriteLine(or);// [5,10,12,13,32,34]
            //}



            // OrderByDecending() -> sort the element by decending order. 

            //List<int> one = new List<int> {10,12,9,6,5,7,4,32 };
            //var result = one.OrderByDescending(x =>x); 

            //foreach(var on in result)
            //{
            //    Console.WriteLine(on);// [32,12,10,9,7,6,5,4]
            //}

            // First() -> return the first element in collection that's match the condition .


            //List<int> numbers = new List<int>{10, 20, 30, 40, 50};

            //int result = numbers.First();

            //Console.WriteLine(result);



            //    List<int> numbers = new List<int>{10, 20, 30, 40, 50};

            //    // First 
            //    Console.WriteLine("First: " + numbers.First()); // [10]

            //    // First with condition
            //    Console.WriteLine(
            //        "First > 25: " + numbers.First(x => x > 25) // [30]
            //    );

            //    // FirstOrDefault => return the first matching element. if nothing is found , it returns the defalut value instead of throwing an exception.
            //    Console.WriteLine(
            //        "First > 100: " + numbers.FirstOrDefault(x => x > 100)
            //    );

            //    // Last => return last element in collection , if no matching element Last() throws an excetion 
            //    Console.WriteLine("Last: " + numbers.Last());

            //    // Count => count number of element.
            //    Console.WriteLine("Count: " + numbers.Count());

            //    // Count with condition 
            //    Console.WriteLine(
            //        "Count > 25: " + numbers.Count(x => x > 25)
            //    );

            //    // Any => check whether at least one element satisfies a condition , it return true or false.
            //    Console.WriteLine(
            //        "Any > 40: " + numbers.Any(x => x > 40)
            //    );

            //// All => check every elements satisfy the condition, it return true.
            //Console.WriteLine(
            //    "All > 0: " + numbers.All(x => x > 0));



            // Contains(), sum (), average(), min(), Max()  => these method are mainly used for searching and calulating values and return bool.

            // contains => it is check whether a collection contain a specific value. return true or false.
            //List<int> five = new List<int> { 10, 20, 30, 40, 50, };
            //bool result = five.Contains(20); // true
            //int results = five.Sum();
            //var avg = five.Average();
            //var maxs = five.Max();
            //var mins = five.Min();

            //Console.WriteLine( " Contain -> " + result); // true
            //Console.WriteLine("sums -> " + results); // 10+20+30 + 40 +50 =150.
            //Console.WriteLine("average -> " + avg); // 150/5 =30.
            //Console.WriteLine("maximum ->" + maxs);//50.
            //Console.WriteLine("minimum ->" + mins);// 10.





            // Distinct(), Skip (), Take()
            // Distinct() -> is used for remove duplicates, print unique elements.
            // skip() -> is used for skip thr elements based on condition.
            // take ()-> return list of specific element in the conditions.


            //List<int> one = new List<int> { 10, 20, 30, 40, 50, 50, 40, 60, 50, 60 };
            //Console.WriteLine("Distinct");
            //var dis = one.Distinct();
            //foreach (var on in dis)
            //{
            //    Console.WriteLine(on);
            //}

            //// Skip => Skip a specified number of elements from the beginning of a collection.
            //Console.WriteLine("\n skip first two");
            //var skips = one.Skip(2);
            //foreach (var to in skips)
            //{
            //    Console.WriteLine(to);


            //}

            // Take() => takes a specific number of element  from the Beginning of a collection. 

            // Console.WriteLine(" \n takes ");
            // var takes = one
            //         .Distinct()
            //      .Where(x=> x>30)

            //          .Skip(0)
            //          .Take(3);
            //foreach(var tak in takes)
            // {
            //     Console.WriteLine(tak);

            // }
            //List<int> list = new List<int> { 10, 20, 30, 40, 50, 60 };
            //int pagenumber = 2;
            //int pagesize = 3;

            //var num = list.OrderByDescending(x => x)
            //    .Skip(1)
            //    .Take(3);
            //foreach(var number in num)
            //{
            //    Console.WriteLine(number);

            //}
            //var output = list.Skip((pagenumber - 1) * pagesize) // 2 - 1 * 3 =3 => 40,50,60
            //    .Take(pagesize);

            //foreach(var outs in output)
            //{
            //    Console.WriteLine(outs);

            //}


            // grouping => groupBy() , ToLookup() , grouping with multiple properties, aggregation ins

            // groupBy() => Grouping the element based on property,defferred excecution, best for querying , group. key
            //ToLookup() => is used to group data by a key and  then quickly access a specific group using that key.,immediate execution, best for direct key access, lookup["AIDS"]
            // tolokup convert a collect into grouped key- value data , where one key can hava multiple values.

            //List<Students> stud = new List<Students>
            //{
            //    new Students{Id=1, Name="samadhan", department="IT", City="Pune"},
            //    new Students{Id=2, Name= "pooja", department="HR" , City= "Indapur"},
            //    new Students{Id=3, Name="rani", department= "IT" , City="Nashik"},
            //    new Students{Id=4, Name="ram", department="CS", City =" Akluj"},
            //    new Students{Id= 5, Name="sham", department="HR", City="Jambud"},
            //    new Students{Id=6, Name="laxman", department="ELE" , City= "Mumbai"}
            //};
            //var result = stud.GroupBy(s => s.department); // group by department.
            //foreach (var group in result)
            //{
            //    Console.WriteLine($"department:{group.Key}");
            //    foreach (var student in group)
            //    {
            //        Console.WriteLine(student.Name);
            //    }
            //}



            //var Lookup = stud.ToLookup(p => p.department);
            //foreach(var s in Lookup["CS"])
            //{
            //    Console.WriteLine(s.Name);
            //}



            //  grouping with multiple properties => means grouping a collection based on two or more properties together.
            // grouping with aggregation function => means first grouping data then performing calculation on each group. 
            // min , max , count, average, sum
            //            var result = stud.GroupBy(e => new
            //            {
            //                e.department,
            //                e.City
            //            });

            //            foreach (var group in result)
            //            {
            //                Console.WriteLine(
            //                    $"Department: {group.Key.department}, City: {group.Key.City}");

            //                foreach (var emp in group)
            //                {
            //                    Console.WriteLine(emp.Name);
            //                }

            //                Console.WriteLine();


            // single => return exactly one element from a collection. if no element matching  or than one element then throw exception


            //List<int> list = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 10 };
            ////var result = list.Single(x => x == 20);

            //// Console.WriteLine(result);


            //// singleordefalut => return exactly one matching element or  default value if element is not found. more than one element still thrown an exception.
            //var sod = list.SingleOrDefault(x => x == 100);
            //Console.WriteLine(sod); // return 0. defalut value.

            //// elementAt => return specific the element at specified index value.
            //var ele = list.ElementAt(2); // 30
            //Console.WriteLine(ele);

            //// elementAtDefalut => return element at specific index  if not present return defalut value.
            //var deele = list.ElementAtOrDefault(10);
            //Console.WriteLine(deele); // 0 return defalut value.

            //// selectMany => is used to flatten multiple nested collection into single collection.

            //List<List<int>> number = new List<List<int>>() { new List<int> { 10, 20 }, new List<int> { 30, 40 }, new List<int> { 50, 60 }, new List<int> { 70, 80 } };
            //var nes = number.SelectMany(x => x);
            //foreach (var item in nes)
            //{
            //    Console.WriteLine(item); // 10,20,30,40,50,60,70,80.

            //}



            // join()=> combine two ore collections based on common key , similar to inner join in sql. 

            List<studentt> students = new List<studentt>
        {
            new studentt { Id = 1, Name = "Samadhan", departmentID = 101 },
            new studentt { Id = 2, Name = "Pooja", departmentID = 102 },
            new studentt { Id = 3, Name = "Rahul", departmentID = 101 },
            new studentt { Id = 4, Name = "Amit", departmentID = 103 }
        };

            List<department> departments = new List<department>
        {
            new department { Id = 101, Name = "IT" },
            new department { Id = 102, Name = "HR" },
            new department { Id = 103, Name = "CS" }
        };
            var result = students.Join(
            departments,
            student => student.departmentID,
            department => department.Id,
            (student, department) => new
            {
                StudentName = student.Name,
                DepartmentName = department.Name
            }
        );

            foreach (var item in result)
            {
                Console.WriteLine(
                    $"{item.StudentName} - {item.DepartmentName}");
            }

        }
    }
}


//    class Students
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string department { get; set; }
//        public string City { get; set; }
//    }
//}



// join 


class studentt
{
    public int Id { get; set; }
    public string Name { get; set; }
    public  int departmentID { get; set; }
}

class department
{
    public int Id { get; set; }
    public string Name { get; set; }
}