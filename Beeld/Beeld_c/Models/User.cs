namespace Beeld_c
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;

    public class User
    {
        // Properties
        public long Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        // Static collection (extent)
        private static List<User> _extent = new List<User>();

        // Constructors
        public User(long id, string name, string password, string email, string phoneNumber)
        {
            Id = id;
            Name = name;
            Password = password;
            Email = email;
            PhoneNumber = phoneNumber;
            _extent.Add(this);
        }

        // Save extent to file (JSON)
        public static void SaveExtent(string filePath)
        {
            var json = JsonConvert.SerializeObject(_extent, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        // Restore extent from file (JSON)
        public static void LoadExtent(string filePath)
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                _extent = JsonConvert.DeserializeObject<List<User>>(json);
            }
        }

        // Retrieve extent (read-only)
        public static IEnumerable<User> GetExtent()
        {
            return _extent.AsReadOnly();
        }
    }

}