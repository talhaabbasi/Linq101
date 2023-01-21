namespace LinqLibrary
{
    public class ListMananger
    {
        public static List<Person> LoadSampleDate()
        {
            List<Person> output = new List<Person>();
            output.Add(new Person { FirstName = "Talha", LastName = "Abbasi 1", DateOfBirth = DateTime.Now, YearsExperience = 0 });
            output.Add(new Person { FirstName = "Talha", LastName = "Abbasi 2", DateOfBirth = DateTime.Now, YearsExperience = 0 });
            output.Add(new Person { FirstName = "Talha", LastName = "Abbasi 3", DateOfBirth = DateTime.Now, YearsExperience = 0 });
            output.Add(new Person { FirstName = "Talha", LastName = "Abbasi 4", DateOfBirth = DateTime.Now, YearsExperience = 0 });
            output.Add(new Person { FirstName = "Talha", LastName = "Abbasi 5", DateOfBirth = DateTime.Now, YearsExperience = 0 });
            output.Add(new Person { FirstName = "Talha", LastName = "Abbasi 6", DateOfBirth = DateTime.Now, YearsExperience = 0 });

            return output;
        }

    }
}
