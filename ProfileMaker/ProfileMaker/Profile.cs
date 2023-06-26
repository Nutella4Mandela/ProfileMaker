using System;

namespace ProfileMaker
{
    class Profile
    {

        // Field
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        // Constructor
        public Profile(string name, int age, string city, string country, string pronouns = "they/them")
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
        }

        // Method
        public string ViewProfile()
        {
            string currentHobbies = "";

            foreach (string hobby in hobbies)
            {
                currentHobbies += hobby + ", ";
            }

            string bio = $"Name: {name}\n Age: {age}\n City: {city}\n Country: {country}\n Pronouns: {pronouns}\n Hobbies: {currentHobbies}";
            return bio;

        }

        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }
    }
}