using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(
                _context.Department.Any()||
                _context.Seller.Any()||
                _context.SalesRecord.Any()
                )
            {
                return;
            }
            Department d1 = new Department(1, "Electronics");
            Department d2 = new Department(2, "Computers");
            Department d3 = new Department(3, "Fashon");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Jonatas", "jonatas@jonatas.com.br", new DateTime(1981, 12, 22), 5000.0, d1);
            Seller s2 = new Seller(2, "Andre", "Andre@andre.com.br", new DateTime(2004, 03, 14), 6000.0, d2);
            Seller s3 = new Seller(3, "Guilherme", "guilherme@guilherme.com.br", new DateTime(2005, 11, 21), 5000.0, d3);
            Seller s4 = new Seller(4, "Ricardo", "ricardo@ricardo.com.br", new DateTime(1975, 02, 08), 3000.0, d3);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2021, 03, 13), 405.0, Models.Enums.SaleStatus.BILLED, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2021, 04, 13), 700.0, Models.Enums.SaleStatus.CANCELED, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2021, 04, 18), 700.0, Models.Enums.SaleStatus.CANCELED, s2);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2021, 04, 21), 700.0, Models.Enums.SaleStatus.PENDING, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2021, 04, 24), 700.0, Models.Enums.SaleStatus.BILLED, s4);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2021, 04, 08), 700.0, Models.Enums.SaleStatus.CANCELED, s3);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2021, 04, 04), 700.0, Models.Enums.SaleStatus.CANCELED, s3);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2021, 04, 03), 700.0, Models.Enums.SaleStatus.CANCELED, s1);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2021, 04, 03), 700.0, Models.Enums.SaleStatus.CANCELED, s2);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2021, 04, 01), 700.0, Models.Enums.SaleStatus.CANCELED, s4);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2021, 04, 10), 700.0, Models.Enums.SaleStatus.CANCELED, s1);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2021, 04, 30), 700.0, Models.Enums.SaleStatus.CANCELED, s1);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12);
            _context.SaveChanges();
        }
    }
}
