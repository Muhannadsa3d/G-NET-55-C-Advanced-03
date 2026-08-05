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
        }
    }
}
