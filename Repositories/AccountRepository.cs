using DataAccessLayer;

namespace Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public BusinessObjects.AccountMember GetAccountById(string accountId)
        {
            throw new NotImplementedException();
        }

        public AccountMember GetAccountMember(string accountID) => AccountDAO.GetAccountById(accountID);

    }
}
