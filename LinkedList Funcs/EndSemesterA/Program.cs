using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Threading;

namespace EndSemesterA
{
    class Program
    {
        static void Main(string[] args)
        {
            //list1
            Node<int> node1 = new Node<int>(10);
            Node<int> node2 = new Node<int>(8);
            Node<int> node3 = new Node<int>(14);
            Node<int> node4 = new Node<int>(7);
            Node<int> node5 = new Node<int>(9);
            Node<int> node6 = new Node<int>(15);

            //list2
            Node<int> node7 = new Node<int>(19);
            Node<int> node8 = new Node<int>(11);
            Node<int> node9 = new Node<int>(14);

            Worker w1 = new Worker("Ido", 1000);
            Worker w2 = new Worker("Ofek", 4000);
            Worker w3 = new Worker("Elad", 1000);
            Worker w5 = new Worker("Ofek", 2000);
            Worker w6 = new Worker("Daniel",1500);
            Worker w7 = new Worker("Ido", 1000);
            Worker w8 = new Worker("Elad", 5);

            //worker list1
            Node<Worker> nodeW1 = new Node<Worker>(w1);
            Node<Worker> nodeW2 = new Node<Worker>(w2);
            Node<Worker> nodeW3 = new Node<Worker>(w3);
            Node<Worker> nodeW5 = new Node<Worker>(w5);

            //worker list2
            Node<Worker> nodeW6 = new Node<Worker>(w6);
            Node<Worker> nodeW7 = new Node<Worker>(w7);
            Node<Worker> nodeW8 = new Node<Worker>(w8);

            
            Node<int> head = node1;
            Node<int> head2 = node7;

            Node<Worker> workerHead = nodeW1;
            Node<Worker> workerHead2 = nodeW6;

            //another paramaters
            int value = 18;
            Worker w4 = new Worker("Michal", 4000);
            int index = 3;

            //list1
            node1.SetNext(node2);
            node2.SetNext(node3);
            node3.SetNext(node4);
            node4.SetNext(node5);
            node5.SetNext(node6);
            node6.SetNext(null);


            //list2
            node7.SetNext(node8);
            node8.SetNext(node9);
            node9.SetNext(null);

            //worker list1
            nodeW1.SetNext(nodeW2);
            nodeW2.SetNext(nodeW3);
            nodeW3.SetNext(nodeW5);
            nodeW5.SetNext(null);

            //worker list2
            nodeW6.SetNext(nodeW7);
            nodeW7.SetNext(nodeW8);
            nodeW8.SetNext(null);


            Course c1 = new Course(1, 38);
            Course c2 = new Course(2, 48);
            Course c3 = new Course(3, 67);
            Course c4 = new Course(4, 51);
            Course c5 = new Course(5, 92);
            Course c6 = new Course(6, 39);

            //courses list
            Node<Course> nc1 = new Node<Course>(c1);
            Node<Course> nc2 = new Node<Course>(c2);
            Node<Course> nc3 = new Node<Course>(c3);
            Node<Course> nc4 = new Node<Course>(c4);
            Node<Course> nc5 = new Node<Course>(c5);
            Node<Course> nc6 = new Node<Course>(c6);

            nc1.SetNext(nc2);
            nc2.SetNext(nc3);
            nc3.SetNext(nc4);
            nc4.SetNext(nc5);
            nc5.SetNext(nc6);
            nc6.SetNext(null);

            Student s1 = new Student("Ido Zalma", nc1);
            Student s2 = new Student("Elad Grossman", nc5);
            Student s3 = new Student("Ofek Bublil", nc2);
            Student s4 = new Student("Alon Kochman", nc4);
            Student s5 = new Student("Michal Goot", nc3);
            Student s6 = new Student("Ely Anavi", nc1);
            Student s7 = new Student("Shaked Dahari", nc4);
            Student s8 = new Student("Daniel Goldfrab", nc3);



            Node<Student> ns1 = new Node<Student>(s1);
            Node<Student> ns2 = new Node<Student>(s2);
            Node<Student> ns3 = new Node<Student>(s3);
            Node<Student> ns4 = new Node<Student>(s4);
            Node<Student> ns5 = new Node<Student>(s5);

            Node<Student> ns6 = new Node<Student>(s6);
            Node<Student> ns7 = new Node<Student>(s7);
            Node<Student> ns8 = new Node<Student>(s8);


            //students list1
            ns1.SetNext(ns2);
            ns2.SetNext(ns3);
            ns3.SetNext(ns4);
            ns4.SetNext(ns5);
            ns5.SetNext(null);

            Node<Student> studentsList1 = ns1;

            //students list2
            ns6.SetNext(ns7);
            ns7.SetNext(ns8);
            ns8.SetNext(null);

            Node<Student> studentsList2 = ns6;


            Student [] studentsClass1=new Student[2];
            studentsClass1[0] = s3;
            studentsClass1[1] = s5;

            Student[] studentsClass2 = new Student[3];
            studentsClass2[0] = s4;
            studentsClass2[1] = s1;
            studentsClass2[2] = s2;

            //students array list
            Node<Student[]> school1 = new Node<Student[]>(studentsClass1);
            Node<Student[]> school2 = new Node<Student[]>(studentsClass2);
            school1.SetNext(school2);

            Node<Student>[] studentsListArray = new Node<Student>[2];
            studentsListArray[0] = studentsList1;
            studentsListArray[1] = studentsList2;


            Console.WriteLine(@"
                __          __  _                            _       _     
                \ \        / / | |                          | |     | |    
                 \ \  /\  / /__| | ___ ___  _ __ ___   ___  | |_ ___| |    
                  \ \/  \/ / _ \ |/ __/ _ \| '_ ` _ \ / _ \ | __/ _ \ |  
                   \  /\  /  __/ | (_| (_) | | | | | |  __/ | || (_)  |   
                    \/  \/ \___|_|\___\___/|_| |_| |_|\___|  \__\___ /    

           
Please Choice one of the following:
0. Exit
1. Lists length
2. Print lists
3. Add a value to the start of the lists
4. Add a value to the end of the lists
5. Add a value to the middle of the lists
6. Delete a value in the beginning of the lists
7. Delete a value in the end of the lists
8. Delete a value in the middle of the lists
9. Return's the first value in the lists
10. Return's the last value in the lists
11. Return's the value in the lists by index
12. Check if the value exists in the lists
13. Check if the lists are circuler 
14. Removing any duplicate values from the lists
15. Return's the duplicate of the same lists
16. Reversing the lists
17. Sorting the lists
18. Check if the lists are identical
19. Merge the lists
20. Merge the lists with no duplicate
21. Merge the lists with values that only exists in both lists
23. Print students average
24. Return's a list with the best students
25. Return's an array with the worst students");

            int choice = int.Parse(Console.ReadLine());
            while (choice > 0 || choice < 26)
            {
               switch(choice)
                {
                    case 1:
                        Console.WriteLine("Click 1 for Int Lists or 2 for Workers Lists");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine(ListLength(head));
                                break;
                            case 2:
                                Console.WriteLine(ListLength(nodeW1));
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("Click 1 for Int Lists or 2 for Workers Lists");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                PrintList(head);
                                break;
                            case 2:
                                PrintList(nodeW1);
                                break;
                        }
                        break;

                    case 3:
                        Console.WriteLine("Click 1 for Int Lists or 2 for Workers Lists");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine(AddFirst(head, value));
                                break;
                            case 2:
                                Console.WriteLine(AddFirst(nodeW1, w4));
                                break;
                        }
                        break;

                    case 4:
                        Console.WriteLine("Click 1 for Int Lists or 2 for Workers Lists");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                AddLast(head, 3);
                                Console.WriteLine(head);
                                break;
                            case 2:
                                AddLast(nodeW1, w4);
                                Console.WriteLine(nodeW1);
                                break;
                        }
                        break;

                    case 5:
                        Console.WriteLine("Click 1 for Int Lists or 2 for Workers Lists");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                AddAfter(node3, 17);
                                Console.WriteLine(head);
                                break;
                            case 2:
                                AddAfter(nodeW2, w4);
                                Console.WriteLine(nodeW1);
                                break;
                        }
                        break;

                    case 6:
                        Console.WriteLine("Click 1 for Int Lists or 2 for Workers Lists");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                DeleteFirstWithoutRef(head);
                                Console.WriteLine(head);
                                break;
                            case 2:
                                DeleteFirstWithoutRef(nodeW1);
                                Console.WriteLine(nodeW1);
                                break;
                        }
                        break;

                    case 7:
                        Console.WriteLine("Click 1 for Int Lists or 2 for Workers Lists");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                DeleteLast(ref head);
                                Console.WriteLine(head);
                                break;
                            case 2:
                                DeleteLast(ref nodeW1);
                                Console.WriteLine(nodeW1);
                                break;
                        }
                        break;

                    case 8:
                        Console.WriteLine("Click 1 for Int Lists or 2 for Workers Lists");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                DeleteAfter(ref node2);
                                Console.WriteLine(head);
                                break;
                            case 2:
                                DeleteAfter(ref nodeW1);
                                Console.WriteLine(nodeW1);
                                break;
                        }
                        break;

                    case 9:
                        Console.WriteLine("Click 1 for Int Lists or 2 for Workers Lists");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine(FirstValue(head));
                                break;
                            case 2:
                                Console.WriteLine(FirstValue(nodeW1));
                                break;
                        }
                        break;

                    case 10:
                        Console.WriteLine("Click 1 for Int Lists or 2 for Workers Lists");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine(LastValue(head));
                                break;
                            case 2:
                                Console.WriteLine(LastValue(nodeW1));
                                break;
                        }
                        break;

                    case 11:
                        Console.WriteLine("Click 1 for Int Lists or 2 for Workers Lists");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine(ReturnValueByIndex(head, index));
                                break;
                            case 2:
                                Console.WriteLine(ReturnValueByIndex(nodeW1, index));
                                break;
                        }
                        break;

                    case 12:
                        Console.WriteLine("Click 1 for Int Lists or 2 for Workers Lists");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine(CheckIfValueExist(head, value));
                                break;
                            case 2:
                                Console.WriteLine(CheckIfValueExist(nodeW1, w4));
                                break;
                        }
                        break;

                    case 13:
                        Console.WriteLine("Click 1 for Int Lists or 2 for Workers Lists");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine(CheckIfRoundedList(head));
                                break;
                            case 2:
                                Console.WriteLine(CheckIfRoundedList(nodeW1));
                                break;
                        }
                        break;

                    case 14:
                        Console.WriteLine("Click 1 for Int Lists or 2 for Workers Lists");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine(head);
                                Console.WriteLine(NoDuplicate(head));
                                break;
                            case 2:
                                Console.WriteLine(nodeW1);
                                Console.WriteLine(NoDuplicate(nodeW1));
                                break;
                        }
                        break;

                    case 15:
                        Console.WriteLine("Click 1 for Int Lists or 2 for Workers Lists");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine(ReturnsSameList(head));
                                break;
                            case 2:
                                Console.WriteLine(ReturnsSameList(nodeW1));
                                break;
                        }
                        break;

                    case 16:
                        Console.WriteLine("Click 1 for Int Lists or 2 for Workers Lists");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                ReversedList(ref head);
                                Console.WriteLine(head);
                                break;
                            case 2:
                                ReversedList(ref nodeW1);
                                Console.WriteLine(nodeW1);
                                break;
                        }
                        break;

                    case 17:
                        Console.WriteLine("Click 1 for Int Lists or 2 for Workers Lists");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                SortList(head);
                                Console.WriteLine(head);
                                break;
                            case 2:
                                SortList(nodeW1);
                                Console.WriteLine(nodeW1);
                                break;
                        }
                        break;

                    case 18:
                        Console.WriteLine("Click 1 for Int Lists or 2 for Workers Lists");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine(CheckIfSameList(head, head2));
                                break;
                            case 2:
                                Console.WriteLine(CheckIfSameList(workerHead, workerHead2));
                                break;
                        }
                        break;

                    case 19:
                        Console.WriteLine("Click 1 for Int Lists or 2 for Workers Lists");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine(MergeLists(head, head2));
                                break;
                            case 2:
                                Console.WriteLine(MergeLists(workerHead, workerHead2));
                                break;
                        }
                        break;

                    case 20:
                        Console.WriteLine("Click 1 for Int Lists or 2 for Workers Lists");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine(MergeListsNoDuplicate(head, head2));
                                break;
                            case 2:
                                Console.WriteLine(MergeListsNoDuplicate(workerHead, workerHead2));
                                break;
                        }
                        break;

                    case 21:
                        Console.WriteLine("Click 1 for Int Lists or 2 for Workers Lists");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine(MergedListsWithSameValues(head, head2));
                                break;
                            case 2:
                                Console.WriteLine(MergedListsWithSameValues(workerHead, workerHead2));
                                break;
                        }
                        break;

                    case 23:
                        PrintsStudentAverage(ns1);
                        break;

                    case 24:
                        Console.WriteLine(BestStudents(school1));
                        break;

                    case 25:
                        Student[] failedStudentsInEveryClass = FailedStudents(studentsListArray);
                        for (int i = 0; i < failedStudentsInEveryClass.Length; i++)
                        {
                            Console.WriteLine(failedStudentsInEveryClass[i].ToString());
                        }
                        break;
                    case 0:
                        Console.WriteLine(@"
______            _______    ______            _______ 
(  ___ \ |\     /|(  ____ \  (  ___ \ |\     /|(  ____ \
| (   ) )( \   / )| (    \/  | (   ) )( \   / )| (    \/
| (__/ /  \ (_) / | (__      | (__/ /  \ (_) / | (__    
|  __ (    \   /  |  __)     |  __ (    \   /  |  __)   
| (  \ \    ) (   | (        | (  \ \    ) (   | (      
| )___) )   | |   | (____/\  | )___) )   | |   | (____/\
|/ \___/    \_/   (_______/  |/ \___/    \_/   (_______/
                                                        ");
                        Thread.Sleep(2000);
                        return;

                    default:
                        Console.WriteLine(@"
    ______                     __   _       ______  ____  _   ________   _____   ______  __  ________   
   / ____/_____________  _____/ /  | |     / / __ \/ __ \/ | / / ____/  /  _/ | / / __ \/ / / /_  __/   
  / __/ / ___/ ___/ __ \/ ___/ /   | | /| / / /_/ / / / /  |/ / / __    / //  |/ / /_/ / / / / / /      
 / /___/ /  / /  / /_/ / /  /_/    | |/ |/ / _, _/ /_/ / /|  / /_/ /  _/ // /|  / ____/ /_/ / / /       
/_____/_/  /_/   \____/_/  (_)     |__/|__/_/ |_|\____/_/ |_/\____/  /___/_/ |_/_/    \____/ /_/        
                                                                                                      ");
                        return;
                }
                Console.WriteLine("Press any key to reset the menu");
                Console.ReadKey();
                //Thread.sleep(5000);
                Console.Clear();
                Console.WriteLine(@"
                __          __  _                            _       _     
                \ \        / / | |                          | |     | |    
                 \ \  /\  / /__| | ___ ___  _ __ ___   ___  | |_ ___| |    
                  \ \/  \/ / _ \ |/ __/ _ \| '_ ` _ \ / _ \ | __/ _ \    
                   \  /\  /  __/ | (_| (_) | | | | | |  __/ | || (_) |   
                    \/  \/ \___|_|\___\___/|_| |_| |_|\___|  \__\___/    

           
Please Choice one of the following:
0. Exit
1. Lists length
2. Print lists
3. Add a value to the start of the lists
4. Add a value to the end of the lists
5. Add a value to the middle of the lists
6. Delete a value in the beginning of the lists
7. Delete a value in the end of the lists
8. Delete a value in the middle of the lists
9. Return's the first value in the lists
10. Return's the last value in the lists
11. Return's the value in the lists by index
12. Check if the value exists in the lists
13. Check if the lists are circuler 
14. Removing any duplicate values from the lists
15. Return's the duplicate of the same lists
16. Reversing the lists
17. Sorting the lists
18. Check if the lists are identical
19. Merge the lists
20. Merge the lists with no duplicate
21. Merge the lists with values that only exists in both lists
23. Print students average
24. Return's a list with the best students
25. Return's an array with the worst students");

                choice = int.Parse(Console.ReadLine());
            }




            //1
            //Console.WriteLine(ListLength(head));
            //Console.WriteLine(ListLength(nodeW1));

            //2
            //PrintList(head);
            //PrintList(nodeW1);

            //3
            //Console.WriteLine(AddFirst(head, value)); 
            //Console.WriteLine(AddFirst(nodeW1,w4));

            //4
            //AddLast(head,3);
            //Console.WriteLine(head);
            //AddLast(nodeW1, w4);
            //Console.WriteLine(nodeW1);

            //5
            //AddAfter(node3, 17);
            //Console.WriteLine(head);
            //AddAfter(nodeW2, w4);
            //Console.WriteLine(nodeW1);

            //6
            //DeleteFirst(ref head);
            //Console.WriteLine(head);
            //DeleteFirst(ref nodeW1);
            //Console.WriteLine(nodeW1);

            //7
            //DeleteLast(ref head);
            //Console.WriteLine(head);
            //DeleteLast(ref nodeW1);
            //Console.WriteLine(nodeW1);

            //8
            //DeleteAfter(ref node2);
            //Console.WriteLine(head);
            //DeleteAfter(ref nodeW1);
            //Console.WriteLine(nodeW1);

            //9
            //Console.WriteLine(FirstValue(head));
            //Console.WriteLine(FirstValue(nodeW1));

            //10
            //Console.WriteLine(LastValue(head));
            //Console.WriteLine(LastValue(nodeW1));

            //11
            //Console.WriteLine(ReturnValueByIndex(head,index));
            //Console.WriteLine(ReturnValueByIndex(nodeW1,index));

            //12
            //Console.WriteLine(CheckIfValueExist(head,value));
            //Console.WriteLine(CheckIfValueExist(nodeW1, w4));

            //13
            //Console.WriteLine(CheckIfRoundedList(head));
            //Console.WriteLine(CheckIfRoundedList(nodeW1));

            //14
            //Console.WriteLine(head);
            //Console.WriteLine(NoDuplicate(head));
            //Console.WriteLine(nodeW1);
            //Console.WriteLine(NoDuplicate(nodeW1));

            //15
            //Console.WriteLine(ReturnsSameList(head));
            //Console.WriteLine(ReturnsSameList(nodeW1));


            //16
            //ReversedList(ref head);
            //Console.WriteLine(head);
            //ReversedList(ref nodeW1);
            //Console.WriteLine(nodeW1);

            //17
            //SortList(head);
            //Console.WriteLine(head);
            //SortList(nodeW1);
            //Console.WriteLine(nodeW1);

            //18
            //Console.WriteLine(CheckIfSameList(head, head2));
            //Console.WriteLine(CheckIfSameList(workerHead,workerHead2));

            //19
            //Console.WriteLine(MergeLists(head,head2));
            //Console.WriteLine(MergeLists(workerHead,workerHead2));

            //20
            //Console.WriteLine(MergeListsNoDuplicate(head,head2));
            //Console.WriteLine(MergeListsNoDuplicate(workerHead,workerHead2));

            //21
            //Console.WriteLine(MergedListsWithSameValues(head, head2));
            //Console.WriteLine(MergedListsWithSameValues(workerHead,workerHead2));

            //23
            //PrintsStudentAverage(ns1);

            //24
            //Console.WriteLine(BestStudents(school1));

            //25
            //Student[] failedStudentsInEveryClass = FailedStudents(studentsListArray);
            //for(int i=0;i< failedStudentsInEveryClass.Length;i++)
            //{
            //    Console.WriteLine(failedStudentsInEveryClass[i].ToString());
            //}

        }


        //1
        public static int ListLength<T>(Node<T> head)
        {
            int counter = 0;
            while (head != null)
            {
                counter++;
                head = head.GetNext();
            }
            return counter;
        }

        //2
        public static void PrintList<T>(Node<T> head)
        {
            Node<T> temp = head;
            if (head==null)
            {
                Console.WriteLine(head);
                return;
            }
            while (temp.GetNext() != null)
            {
                Console.WriteLine(temp.GetValue());
                temp = temp.GetNext();
            }
            Console.WriteLine(temp.GetValue());
        }

        //3
        public static Node<T> AddFirst<T>(Node<T> head, T value)
        {
            if (head==null)
            {
                return null;
            }
            Node<T> newNode = new Node<T>(value);
            newNode.SetNext(head);
            head = newNode;
            return head;
        }

        //4
        public static void  AddLast<T>(Node<T> head, T value)
        {
            if (head == null)
            {
                return;
            }
            Node<T> current=new Node<T>(value);
            Node<T> newNode = head;
            while(newNode.HasNext())
            {
                newNode = newNode.GetNext();
            }
            newNode.SetNext(current);
        }

        //5
        public static void AddAfter<T>(Node<T> node3, T value)
        {
            Node<T> newNode = new Node<T>(value);//חוליה חדשה ששוווה לערך שהתקבל כפרמטר
            newNode.SetNext(node3.GetNext());
            node3.SetNext(newNode);
        }

        //6
        public static void DeleteFirst<T>(ref Node<T> head)//using a ref type to return a list without the first value
        {
            Node<T> current = head;
            if (head == null)
                return;
            head = head.GetNext();
            current.SetNext(null);
        }

        public static Node<T> DeleteFirstWithoutRef<T>(Node<T> head)
        {
            Node<T> temp = head;
            if (head == null)
                return null;
            head = head.GetNext();
            temp.SetNext(null);
            return head;
        }

        //7
        public static void DeleteLast<T>(ref Node<T> head)//using a ref type to return a list without the last value because the address is changing
        {
            if (head == null)
                return;
            Node<T> current = head;
            Node<T> prev = null;
            while(current.HasNext())
            {
                prev = current;
                current = current.GetNext();
            }
            prev.SetNext(null);
        }


        //8
        public static void DeleteAfter<T>(ref Node<T> prev)
        {
            Node<T> temp=prev;
            if(temp != null && temp.HasNext())
            {
                Node<T> current = temp.GetNext();//node5=55
                temp.SetNext(current.GetNext());//node6=30
                current.SetNext(null);//55-->null

            }
        }

        //9
        public static T FirstValue<T>(Node<T> head)
        {
            return head.GetValue();
        }


        //10
        public static T LastValue<T>(Node<T> head)
        {
            Node<T> temp = head;
            while(temp.HasNext())
            {
                temp = temp.GetNext();
            }
            T lastValue = temp.GetValue();
            return lastValue;
        }

        //11
        public static T ReturnValueByIndex<T>(Node<T> head, int index)
        {
            if (head == null)
                return head.GetValue();
            Node<T> current = head;
            for(int i=0;i<index-1;i++)
            {
                current = current.GetNext();
            }
            return current.GetValue();
        }


        //12
        public static bool CheckIfValueExist<T>(Node<T> head, T value)
        {
            if (head == null)
                return false;
            Node<T> current = head;
            while(current!=null)
            {
                if(current.GetValue().Equals(value))
                {
                    return true;
                }
                current = current.GetNext();
            }
            return false;
        }


        //13
        public static bool CheckIfRoundedList<T>(Node<T> head)
        {
            if (head == null)
                return true;//empty list is a rounded list
            Node<T> temp = head.GetNext();
            while(temp!=null && temp!=head)//checking if temp is not null and its not compare to the first node
            {
                temp = temp.GetNext();
            }
            return (temp == head);
        }

        //14
        public static Node<T> NoDuplicate<T>(Node<T> head)
        {
            if (head == null)
                return null;
            Node<T> newList = new Node<T>(head.GetValue());
            Node<T> current = newList;
            head = head.GetNext();
            while(head!=null)
            {
                if (!CheckIfValueExist(newList, head.GetValue()))
                {
                    Node<T> newNode = new Node<T>(head.GetValue());
                    current.SetNext(newNode);
                    current = current.GetNext();
                }             
                head = head.GetNext();
            }
            return newList;
        }


       //15
       public static Node<T>ReturnsSameList<T>(Node<T> head)
       {
            if (head == null)
                return null;
            Node<T> newList=new Node<T>(head.GetValue());
            Node<T> current=newList;
            while(head.HasNext())
            { 
                Node<T> newNode = new Node<T>(head.GetNext().GetValue());
                current.SetNext(newNode);
                current = current.GetNext();
                head = head.GetNext();
            }
            return newList;
       }

        //16
        public static void ReversedList<T>(ref Node<T>head)
        {
            if (head == null)
                return;
            Node<T> prev = null;
            Node<T> current = head;//10 12 14 18 18 20
            Node<T> next = null;
            while (current != null)
            {
                next = current.GetNext();//12 14 18 18 20
                current.SetNext(prev);
                prev = current;
                current = next;
            }
            head = prev;
        }


        //17
        public static void SortList<T>(Node<T> head) where T : IComparable<T> // where T:IComparable<T>- checks if the class implements the interface
        {
            // if there is  nothing to sort:
            if (head == null || head.GetNext() == null) return;

            //bubble sort algorithm
            //comaring the left element(current) with the next element (current.GetNext()) using CompareTo Method
            //than we swap the pairs until there is no more swaps needed

            Node<T> list = head;
            while(list.GetNext()!=null)
            {
                Node<T> current = head;
                while (current.GetNext() != null)
                {
                    if (current.GetValue().CompareTo(current.GetNext().GetValue()) > 0)//replacing the current node value with the next current value
                    {
                        T temp = current.GetValue();//saving the current node value
                        current.SetValue(current.GetNext().GetValue());//putting the next node value in the current value
                        current.GetNext().SetValue(temp);//puuting the current node value in the next current value
                    }
                    current = current.GetNext();
                }
                list = list.GetNext();
            }
        }

        //18
        public static bool CheckIfSameList<T>(Node<T> list1, Node<T> list2) where T : IComparable<T>
        {
            if (ListLength(list1) != ListLength(list2)) return false; //the lists are not the same length so cant be the same

            while (list1 != null)
            {
                if (list1.GetValue().Equals(list2.GetValue()))
                    return false;
                list1 = list1.GetNext();
                list2 = list2.GetNext();
            }
            return true;
        }

        //19
        public static Node<T> MergeLists<T>(Node<T>list1, Node<T>list2)
        {
            //creating a new list and making it as the same as the first list
            Node<T> mergedList = ReturnsSameList(list1);
            while(list2!=null)
            {
                AddLast(mergedList, list2.GetValue());
                list2 = list2.GetNext();
            }
            return mergedList;
        }


        //20
        public static Node<T> MergeListsNoDuplicate<T>(Node<T>list1, Node<T>list2)
        {
            Node<T> mergedList = MergeLists(list1, list2);
            return NoDuplicate(mergedList);           
        }

        //21
        public static Node<T> MergedListsWithSameValues<T>(Node <T> list1, Node<T> list2)
        {
            Node<T> newCrossedList = new Node<T>(list1.GetValue());//we will deal with it later
            Node<T> temp = list1;
            while(temp!=null)
            {
                if(CheckIfValueExist(list2,temp.GetValue()) || list2.Equals(temp.GetValue()))//checking if the value of temp exists in list2 and checking if its an object
                {
                    AddLast(newCrossedList, temp.GetValue());//adding the new value to the end of the crossed list
                    temp = temp.GetNext();//moving forward to the next element
                    continue;//going straight to the loop
                }
                temp = temp.GetNext();
            }
            if (!list2.Equals(list1.GetValue()))//checking if the first elemnt of list1 exists in list2
                return DeleteFirstWithoutRef(newCrossedList);//if not than return the crossed list without the first element
            return newCrossedList;//else return the crossed list as it is
        }

        //23
        public static void PrintsStudentAverage(Node<Student> studentsList)
        {
            double sum = 0;
            while(studentsList!=null)
            {
                Node<Course> courses = studentsList.GetValue().getCoursesList();
                int numberOfCourses = courses.NumberOfNodes();
                while(courses!=null)
                {
                    sum += courses.GetValue().getCourseGrade();
                    courses = courses.GetNext();
                }
                Console.WriteLine($"{studentsList.GetValue().getName()}'s average grade is {sum/ numberOfCourses:f2}");
                sum = 0;
                studentsList = studentsList.GetNext();
            }
        }

        //24
        public static Node<Student> BestStudents(Node<Student[]>school)
        {
            //first we create a lists of the best students with one fictive student
            Node<Student> BestStudentsList = new Node<Student>(default(Student));
            double bestStudentAvg = 0;
            Node<Student> maxAvgStudent = new Node<Student>(default(Student));
            //loop for the list of student arrays
            while(school!=null)
            {
                for(int i=0;i<school.GetValue().Length;i++)
                {
                    //save the current student 
                     Student student = school.GetValue()[i];
                    //using the GetAverage method from the student class to check for the best avg
                    if(student.GetAverageGrade() > bestStudentAvg)
                    {
                        bestStudentAvg = student.GetAverageGrade();
                        maxAvgStudent = new Node<Student>(student);
                    }
                }
                //adding the student with the beest average in class
                AddLast(BestStudentsList, maxAvgStudent.GetValue());
                bestStudentAvg = 0;
                school = school.GetNext();
            }
          return DeleteFirstWithoutRef(BestStudentsList);
        }

        //25
        public static Student[] FailedStudents(Node<Student>[] studentsListArray)
        {
            //student object array as the same length as the nodes array
            Student[] failedStudentsArray = new Student[studentsListArray.Length];

            //initiate the variables that will count the failed courses and check the most failed student
            int failedCounter = 0;
            int maxFailedCourses = 0;

            //creating a student object that we will override later
            Student mostFailedStudent = new Student("ido", new Node<Course>(new Course(0, 0)));

            //loop that goes on the nodes array
            for(int i=0;i<studentsListArray.Length;i++)
            {
                //temp is a student list
                Node<Student> temp = studentsListArray[i];
                while(temp!=null)
                {
                    //creating a courses list node for every student
                    Node<Course> coursesList = temp.GetValue().getCoursesList();
                    //running on the courses list of every student
                    while(coursesList!=null)
                    {
                        //checking if he failed the course
                        if(coursesList.GetValue().getCourseGrade()<55)
                        {
                            failedCounter++;
                        }
                        coursesList = coursesList.GetNext();
                    }
                    //checking who is the student that failed the most courses
                    if(failedCounter>maxFailedCourses)
                    {
                        //saving the max failed courses student in every node and its name and courses list and create a new student object with it
                        maxFailedCourses = failedCounter;
                        string studentName= temp.GetValue().getName();
                        Node<Course> courses= temp.GetValue().getCoursesList();
                        mostFailedStudent = new Student(studentName, courses);
                    }
                failedStudentsArray[i] = mostFailedStudent;
                failedCounter = 0;
                temp = temp.GetNext();
                }
                maxFailedCourses = 0;              
            }
            return failedStudentsArray;
        }
    }
}
