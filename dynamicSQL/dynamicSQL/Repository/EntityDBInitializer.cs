using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamicSQL.Repository
{
    public class EntityDBInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<LookupContext>
    {

        protected override void Seed(LookupContext context)
        {
                 
            var col1 = new ColumnName();
            col1.ID = 1;
            col1.ColName = "prop1";

            context.cols.Add(col1);

            var col2 = new ColumnName();
            col2.ID = 1;
            col2.ColName = "prop2";
            context.cols.Add(col2);

            var listCols = new List<ColumnName>();
            listCols.Add(col1);
            listCols.Add(col2);

            var lookupName = new LookupName();
            lookupName.ID = 1;
            lookupName.Name = "name1";
            lookupName.ColumnNames = listCols;

            context.Lookups.Add(lookupName);



            context.SaveChanges();

            
        }
    }
}
