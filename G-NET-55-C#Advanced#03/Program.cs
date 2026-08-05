namespace G_NET_55_C_Advanced_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            //List<int> grades = new() { 85, 92, 78, 95, 88, 70, 100, 65 };

            //// Print the collection
            //Console.WriteLine("Grades: " + string.Join(", ", grades));

            //// Count, first and last grade
            //Console.WriteLine("Count: " + grades.Count);
            //Console.WriteLine("First grade: " + grades.First());
            //Console.WriteLine("Last grade: " + grades.Last());

            //// Sort ascending
            //grades.Sort();
            //Console.WriteLine("\nSorted Grades: " + string.Join(", ", grades));

            //// Get the first grade above 90
            //int firstAbove90 = grades.First(g => g > 90);
            //Console.WriteLine("\nFirst grade above 90: " + firstAbove90);

            //// Get all grades below 75 (failing grades)
            //var failingGrades = grades.Where(g => g < 75).ToList();
            //Console.WriteLine("\nFailing grades (<75): " + string.Join(", ", failingGrades));

            //// Remove all failing grades
            //grades.RemoveAll(g => g < 75);
            //Console.WriteLine("\nGrades after removing failing: " + string.Join(", ", grades));

            //// Check if any grade equals 100
            //bool hasPerfect = grades.Contains(100);
            //Console.WriteLine("\nAny grade equals 100? " + hasPerfect);

            //// Create List<string> where each grade becomes "Grade: X"
            //List<string> gradeStrings = grades.Select(g => $"Grade: {g}").ToList();
            //Console.WriteLine("\nGrade Strings:");
            //foreach (var s in gradeStrings) Console.WriteLine(s);

            #endregion
            #region Exercise 2: Leaderboard
            //    SortedDictionary<int, string> leaderboard = new()
            //{
            //    {500, "Ahmed"},
            //    {200, "Sara"},
            //    {800, "Ali"},
            //    {350, "Mona"}
            //};

            //    // Print all entries (sorted by score automatically)
            //    Console.WriteLine("--- Leaderboard ---");
            //    foreach (var entry in leaderboard)
            //    {
            //        Console.WriteLine($"{entry.Key} = {entry.Value}");
            //    }

            //    // Access the first key and first value
            //    int firstKey = leaderboard.Keys.Min();
            //    string firstValue = leaderboard[firstKey];
            //    Console.WriteLine($"\nFirst Key: {firstKey}, First Value: {firstValue}");

            //    // Check if score 500 exists
            //    bool has500 = leaderboard.ContainsKey(500);
            //    Console.WriteLine("\nScore 500 exists? " + has500);

            //    // Safely get the player with score 999
            //    if (leaderboard.TryGetValue(999, out string player999))
            //        Console.WriteLine("\nPlayer with score 999: " + player999);
            //    else
            //        Console.WriteLine("\nPlayer with score 999 not found.");

            //    // Remove the player with score 200
            //    leaderboard.Remove(200);

            //    // Print updated list
            //    Console.WriteLine("\n--- Updated Leaderboard ---");
            //    foreach (var entry in leaderboard)
            //    {
            //        Console.WriteLine($"{entry.Key} = {entry.Value}");
            //    }
            #endregion
            #region Exercise 3: Phone Book

            //    // 1. Create a Collection with 4 contacts
            //    Dictionary<string, string> phoneBook = new()
            //{
            //    {"Ahmed", "0105000000"},
            //    {"Sara", "0102000000"},
            //    {"Ali", "0108000000"},
            //    {"Mona", "0103500000"}
            //};

            //    // 2. Add a new contact using [] syntax (add or update)
            //    phoneBook["Omar"] = "0109999999"; // لو مش موجود يضيف، لو موجود يحدث

            //    // 3. Try adding a duplicate using .Add() — catch the exception
            //    try
            //    {
            //        phoneBook.Add("Ahmed", "0111111111");
            //    }
            //    catch (ArgumentException ex)
            //    {
            //        Console.WriteLine("Error: " + ex.Message);
            //    }

            //    // 4. Try adding a duplicate using .TryAdd()
            //    bool added = phoneBook.TryAdd("Ahmed", "0111111111");
            //    Console.WriteLine("TryAdd Ahmed succeeded? " + added);

            //    // 5. Search for a contact that doesn’t exist
            //    if (phoneBook.ContainsKey("Youssef"))
            //        Console.WriteLine("Youssef found: " + phoneBook["Youssef"]);
            //    else
            //        Console.WriteLine("Youssef not found.");

            //    // 6. Get a contact with a fallback of "Not Found"
            //    string result = phoneBook.GetValueOrDefault("Nada", "Not Found");
            //    Console.WriteLine("Nada: " + result);

            //    // 7. Print all Keys on one line
            //    Console.WriteLine("\nContacts: " + string.Join(", ", phoneBook.Keys));

            //    // 8. Print all Values on another line
            //    Console.WriteLine("Numbers: " + string.Join(", ", phoneBook.Values));
            #endregion
            #region Exercise 4: Unique Email Validator
            //    HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            //{
            //    "ahmed@test.com",
            //    "AHMED@test.com",
            //    "sara@test.com",
            //    "Sara@Test.Com"
            //};

            //    // Print Count
            //    Console.WriteLine("Email Count: " + emails.Count);

            //    // Explain why
            //    Console.WriteLine("Explanation: HashSet ignores duplicates (case-insensitive), so only 2 unique emails are stored.");

            //    // 2. Create two sets
            //    HashSet<int> setA = new() { 1, 2, 3, 4, 5 };
            //    HashSet<int> setB = new() { 4, 5, 6, 7, 8 };

            //    // UnionWith
            //    HashSet<int> union = new(setA);
            //    union.UnionWith(setB);
            //    Console.WriteLine("\nUnion: " + string.Join(", ", union));

            //    // IntersectWith
            //    HashSet<int> intersect = new(setA);
            //    intersect.IntersectWith(setB);
            //    Console.WriteLine("Intersection: " + string.Join(", ", intersect));

            //    // ExceptWith
            //    HashSet<int> except = new(setA);
            //    except.ExceptWith(setB);
            //    Console.WriteLine("Except (A - B): " + string.Join(", ", except));

            //    // IsSubsetOf
            //    HashSet<int> subset = new() { 1, 2 };
            //    Console.WriteLine("\nIs {1,2} subset of A? " + subset.IsSubsetOf(setA));
            #endregion
            #region Exercise 5: Print Queue Simulator

            //// 1. Create a Queue<string> and enqueue 5 documents
            //Queue<string> printQueue = new();
            //printQueue.Enqueue("Report.pdf");
            //printQueue.Enqueue("Invoice.pdf");
            //printQueue.Enqueue("Letter.docx");
            //printQueue.Enqueue("Resume.pdf");
            //printQueue.Enqueue("Photo.jpg");

            //// 2. Print the queue contents and Count
            //Console.WriteLine("--- Print Queue ---");
            //foreach (var doc in printQueue)
            //{
            //    Console.WriteLine(doc);
            //}
            //Console.WriteLine("Count: " + printQueue.Count);

            //// 3. Use Peek to see which document will print next
            //Console.WriteLine("\nNext to print (Peek): " + printQueue.Peek());

            //// 4. Process the queue: Dequeue each document
            //Console.WriteLine("\n--- Processing Queue ---");
            //while (printQueue.Count > 0)
            //{
            //    string doc = printQueue.Dequeue();
            //    Console.WriteLine("Printing: " + doc);
            //}

            //// 5. Try TryDequeue on the now-empty queue
            //if (printQueue.TryDequeue(out string result))
            //{
            //    Console.WriteLine("\nPrinting: " + result);
            //}
            //else
            //{
            //    Console.WriteLine("\nQueue is empty, nothing to dequeue.");
            //}
            #endregion
            #region Exercise 6: Browser History (Undo)
            //Stack<string> history = new();

            //// 2. Push 5 URLs
            //history.Push("google.com");
            //history.Push("github.com");
            //history.Push("stackoverflow.com");
            //history.Push("youtube.com");
            //history.Push("claude.ai");

            //// 3. Use Peek to see the current page (top of stack)
            //Console.WriteLine("Current page (Peek): " + history.Peek());

            //// 4. Press "back" 3 times using Pop
            //Console.WriteLine("\n--- Going Back ---");
            //for (int i = 0; i < 3; i++)
            //{
            //    string leftPage = history.Pop();
            //    Console.WriteLine("Leaving: " + leftPage);
            //}

            //// 5. Print the current page after going back
            //Console.WriteLine("\nCurrent page after back: " + history.Peek());

            //// 6. Try TryPop on an empty stack
            //history.Clear(); // نفرغ الستاك علشان نجرب TryPop
            //if (history.TryPop(out string result))
            //{
            //    Console.WriteLine("\nPopped: " + result);
            //}
            //else
            //{
            //    Console.WriteLine("\nStack is empty, nothing to pop.");
            //}
            #endregion
        }
    }
}
