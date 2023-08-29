namespace ContactList
{
    public class ContactList
    {
        Dictionary<string, string> contactList = new Dictionary<string, string>();

        public void AddContact(string name, string category)
        {
            contactList.Add(name, category);
        }

        public void DisplayContacts()
        {
            foreach (var contact in contactList.Values)
            {
                Console.WriteLine(contact);
            }
        }
    }
}
