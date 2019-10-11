using System;
using System.Collections.Generic;

namespace Rich_Editor
{
    class CsvReader
    {
        public static List<User> ReadUsersFromCsv(string fileName)
        {
            List<User> users = new List<User>();
           
            try
            {
                string[] lines = System.IO.File.ReadAllLines(fileName);
                
                foreach (string line in lines)
                {
                    string[] split = line.Split(',');

                    User user = new User
                    {
                        Username = split[0],
                        Password = split[1],
                        FirstName = split[2],
                        LastName = split[3],
                        DOB = split[4]
                    };

                    if (split[5] == "ReadOnly") user.Type = UserType.ReadOnly;
                    else user.Type = UserType.ReadWrite;

                    users.Add(user);
                }

                return users;
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to read CSV file: " + e.Message);
            }

            return users;
        }

        public static void WriteUsersIntoCsv(string fileName, List<User> users)
        {
            List<string> lines = new List<string>();

            foreach (User user in users)
            {
                string line = $"{user.Username},{user.Password},{user.FirstName},{user.LastName},{user.DOB},{user.Type}";
                lines.Add(line);
            }

            System.IO.File.WriteAllLines(fileName, lines);
        }
    }
}
