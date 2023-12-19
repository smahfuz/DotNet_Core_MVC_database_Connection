# DotNet_Core_MVC_database_Connection

1. Create a new Porjet(MVC)
2. Create a new Folder (name will be DBContext)

2.1---- Create a new class that will perform main work and name will be xxxxDBContext.cs
 
2.2---- Create a new  class that will type of all data. let name is MyDataType.cs


3. #### Entity framework install. these are tools,  core, sql-server

4. SQL server apps open and make a server and connect

***** initial kaj korlam, erpor code likhte hobe******

5. ebar MyDataType a type gula declare kore dibo

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

6.  xxxxDBContext.cs this code wil update by some changes. this are
7.  
    6.1 ----xxxxDBContext eta DbContext ke herit korbe, tokhoni entity package using akare likhte hobe. ba auto fix korleo chole asbe.
    
    6.2-----constractor create korte hobe, ja ekta value return korbe.
    
                public MulKajDBContext(DbContextOptions options) : base(options){ }
    
                public DbSet<MyDataTypesAre>elomelo { get; set; }
    
9. add this to appsetting
                 "ConnectionStrings": {
                   "fuzzy": "Server=DESKTOP-AOOCBQV;Database=myIdentity;Trusted_Connection=True; TrustServerCertificate=True"
                 }
               } 

10. add this to program.cs

builder.Services.AddDbContext<MulKajDBContext>(options =>

options.UseSqlServer(builder.Configuration.GetConnectionString("fuzzy")));

using gula thikthak kore ase ki dekhte hobe


Add-Migration "FirstMigration"

update-database

####  hoye jaoyar kotha


-- to remove specific migration
update-database -migration "migration name"
-- to remove all migration
update-database -migration 0

- - to remove last migratio
remove-migration -force
    
        

  


   
