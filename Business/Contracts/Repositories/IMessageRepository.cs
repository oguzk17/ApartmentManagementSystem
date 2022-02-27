using Business.Contracts.Repositories.Commons;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Contracts.Repositories
{
	public interface IMessageRepository: IRepositoryBase<Message> 
	{
		Task<IReadOnlyList<Message>> GetAllReceiveMessageDetail(int userId);
		Task<IReadOnlyList<Message>> GetAllSendMessageDetail(int userId);

	}
}
