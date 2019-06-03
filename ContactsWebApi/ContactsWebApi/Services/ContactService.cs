using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsWebApi.Models;
using ContactsWebApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ContactsWebApi.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public Contact Create(Contact contact)
        {
            return _contactRepository.Create(contact);
        }

        public StatusCodeResult Delete(int id)
        {
            var deletedContact = _contactRepository.Read(id);
            if (deletedContact == null)
                throw new Exception("Contact not found");

            return _contactRepository.Delete(id);
        }

        public List<Contact> Read()
        {
            return _contactRepository.Read();
        }

        public Contact Read(int id)
        {
            return _contactRepository.Read(id);
        }

        public Contact Update(int id, Contact contact)
        {
            var updateContact = _contactRepository.Read(id);
            if (updateContact == null)
                throw new Exception("Contact not found!");

            return _contactRepository.Update(contact);
        }
    }
}
