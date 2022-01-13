namespace Bera_Catalin_Lab10.Data
{
    public class ShoppingListDatabaseBase
    {
        public Task<int> SaveListProductAsync(ListProduct listp)
        {
            if (listp.ID != 0)
            {
                return _database.UpdateAsync(listp);
            }
            else
            {
                return _database.InsertAsync(listp);
            }
        }
    }
}