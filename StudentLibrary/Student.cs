namespace StudentLibrary
{
    public class Student
    {
        public string Name { get; set; }

        public string Adress { get; set; }

        public Student(string name, string adress)
        {
            Name = name;
            Adress = adress;
        }

        public Student()
        {
        }

        /// <summary>
        /// Metode til navn og adresse i en tekst streng
        /// </summary>
        /// <returns>navn og adress på en studerende</returns>
        public string NameAdresstext()
        {
            return "Name: " + Name + " Adress: " + Adress;
        }
    }
}