using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsWebApi.Models;

namespace ContactsWebApi.Services
{
    public interface IContactService
    {
        Contact Create(Contact contact);
        void Delete(int id);
        List<Contact> Read();
        Contact Read(int id);
        Contact Update(int id, Contact contact);
    }
}
