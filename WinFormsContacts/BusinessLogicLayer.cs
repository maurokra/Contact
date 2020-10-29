using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsContacts
{
    public class BusinessLogicLayer
    {
        private DataAccessLayer _dataAccessLayer;

        public BusinessLogicLayer()
        {
            _dataAccessLayer = new DataAccessLayer();
        }

        public Contact SaveContact(Contact contact)
        {
            if (contact.Id == 0)
                _dataAccessLayer.InsertContact(contact);
            else
                _dataAccessLayer.UpdateContac(contact);
            return contact;
        }

        public List<Contact> GetContacts(string searchText = null)
        {
           return _dataAccessLayer.GetContacts(searchText);
        }

        public void DeleteContact(int Id)
        {
            _dataAccessLayer.DeleteContact(Id);
        }
    }
}
