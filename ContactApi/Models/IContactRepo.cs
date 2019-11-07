using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactApi.Models
{
    public interface IContactRepo
    {
        List<Contact> GetContacts();
    }
}
