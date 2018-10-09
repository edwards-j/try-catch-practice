using System;
using System.Collections.Generic;

namespace try_catch {
    public class AddressBook {
        public Dictionary<string, Contact> ContactList = new Dictionary<string, Contact> ();
        public void AddContact (Contact contact) {
            ContactList.Add (contact.Email, contact);

        }
        public Contact GetByEmail (string email) {
            Contact currentContact = new Contact();
            foreach (KeyValuePair<string, Contact> entry in ContactList) {
                if (entry.Key == email) {
                    currentContact = entry.Value;
                }
            }
            return currentContact;
        }
    }
}