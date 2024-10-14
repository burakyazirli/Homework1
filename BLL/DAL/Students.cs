#nullable disable 

namespace BLL.DAL
{
    public class Students
    {
        //private int id;

        //public void SetId(int id)
        //{
        //    this.id = id;
        //}
        //public int GetId() 
        //{
        //    return this.id;
        //}
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? BirthDate { get; set; }
        public decimal Gpa { get; set; }

    }
}