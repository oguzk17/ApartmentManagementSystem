using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts.Repositories
{
    public class MessageRepository : RepositoryBase<Message>, IMessageRepository
    {
        private IMapper _mapper;
        protected string[] includes = { "Sender", "Receiver" };
        public MessageRepository(SiteContext dbContext, IMapper mapper) : base(dbContext)
        {
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<Message>> GetAllReceiveMessageDetail(int userId)
        {

            var result = await base.GetAllAsync(r => r.Receiver.Id == userId, includeStrings: includes);

            return result;
        }

        public async Task<IReadOnlyList<Message>> GetAllSendMessageDetail(int userId)
        {

            //var result = await base.GetAllAsync(r => r.Sender.Id == userId);
            var result = await base.GetAllAsync(r => r.Sender.Id == userId, includeStrings: includes);
            return result;
        }


    }
}
