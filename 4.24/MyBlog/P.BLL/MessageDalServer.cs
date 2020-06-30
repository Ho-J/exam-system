using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P.Model;
using P.DAL;

namespace P.BLL
{
    public class MessageDalServer
    {
        MessageDal messageDal = new MessageDal();
        public MessageDb getMessage()
        {
            return messageDal.getMessage();
        }
        public int UpdateMessage(MessageDb messageDb)
        {
            return messageDal.UpdateMessage(messageDb);
        }
    }
}
