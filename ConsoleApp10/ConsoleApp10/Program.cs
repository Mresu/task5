namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human
            {
                Name = "Resul",
                Surname = "muradov",
                Gender = "Male",
                Age = 30
            };
            human1.ShowInfo();

            Doctor doctor1 = new Doctor
            {
                Name = "NIYAMEDDIN",
                Surname = "Musayev",
                Gender = "male",
                Age = 35,
                Speciality = "Cardiologist",
                Experience = -10
            };
            doctor1.ShowInfo();
        }
    }
}
