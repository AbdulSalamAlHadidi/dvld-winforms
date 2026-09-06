using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Desktop.Pages.People
{
    public static class MockPeopleData
    {
        public static List<PersonRow> GetSample()
        {
            return new List<PersonRow>
            {
                new PersonRow { Id = 1, FullName = "Ahmed Khaled Saleh", NationalNumber = "29501011234567", Gender = "Male", DateOfBirth = "1995-01-01", Phone = "0100000001", Status = "Active" },
                new PersonRow { Id = 2, FullName = "Mona Adel Fawzy", NationalNumber = "29803022345678", Gender = "Female", DateOfBirth = "1998-03-02", Phone = "0100000002", Status = "Active" },
                new PersonRow { Id = 3, FullName = "Youssef Tarek Hassan", NationalNumber = "29202033456789", Gender = "Male", DateOfBirth = "1992-02-03", Phone = "0100000003", Status = "Inactive" },
                new PersonRow { Id = 4, FullName = "Salma Nabil Ibrahim", NationalNumber = "29904044567890", Gender = "Female", DateOfBirth = "1999-04-04", Phone = "0100000004", Status = "Active" },
                new PersonRow { Id = 5, FullName = "Omar Sami Farouk", NationalNumber = "29001055678901", Gender = "Male", DateOfBirth = "1990-01-05", Phone = "0100000005", Status = "Active" },
            };
        }
    }
}