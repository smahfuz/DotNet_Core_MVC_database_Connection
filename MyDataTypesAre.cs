using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SecondPractice.DBContext
{
    public class MyDataTypesAre
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string District { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string Village { get; set; }
    }
}
