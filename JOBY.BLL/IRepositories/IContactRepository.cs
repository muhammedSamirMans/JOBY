using JOBY.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOBY.BLL.IReposatories
{
    public interface IContactRepository
    {
        List<ContactMessage> GetAllMessagesList();
        void InsertMessage(ContactMessage message);
    }
}
