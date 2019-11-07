using System.Collections.Generic;
using System.Linq;

namespace ContactApi.Models
{
    public class ContactRepository : IContactRepo
    {
        private readonly ContactDb contactDb;

        public ContactRepository(ContactDb contactDb)
        {
            this.contactDb = contactDb;
        }
        public List<Contact> GetContacts()
        {
            return contactDb.Contacts.ToList();
        }
    }
}
