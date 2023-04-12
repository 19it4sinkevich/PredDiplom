using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
            new Book
            {
                Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                IBAN = "1723323947",
                Name = "Пикник на обочине",
                Genre = "Фантастика",
                Athor = "Борис Стругатский, Аркадий Стругатский",
                Description = "«Пикни́к на обо́чине» — философская фантастическая повесть братьев Стругацких, " +
                "впервые изданная в 1972 году.",
                TimeOfIssue = "22.03.2023",
                TimeOfReturn = "14.04.2023"
            },
            new Book
            {
                Id = new Guid("c9d4c911-49b6-410c-bc78-2d54a9991870"),
                IBAN = "786324345",
                Name = "Град обреченный",
                Genre = "Роман",
                Athor = "Борис Стругатский, Аркадий Стругатский",
                Description = "««Град обрече́нный» — философский роман Аркадия и Бориса Стругацких." +
                " Писался «в стол», когда братья оказались в состоянии мировоззренческого кризиса," +
                " а затем были резко ограничены в возможностях публиковаться. ",
                TimeOfIssue = "22.03.2023",
                TimeOfReturn = "14.04.2023"
            }) ;
        }
    }

}
