using JOBY.BLL.IReposatories;
using JOBY.DAL.DataContext;
using JOBY.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOBY.BLL.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly DatabaseContext _context;
        public ContactRepository(DatabaseContext databaseContext)
        {
            _context = databaseContext;
        }
        public List<ContactMessage> GetAllMessagesList()
        {
            return new List<ContactMessage>
            {
                new ContactMessage{Message="test",Email="test@mail",Name="MoTest",Subject="test for rep"}
            };
        }

        public void InsertMessage(ContactMessage message)
        {
            //var list = _context.contactMessages.Count();
            _context.contactMessages.Add(message);
            _context.SaveChanges();
        }
    }
}
