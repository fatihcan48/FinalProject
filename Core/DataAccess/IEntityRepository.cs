using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    // Interface'imize her veri tipinin yazılmasını istemiyoruz. Sadece Entity nesneleri veilebilsin istiyoruz.
    // Generic Constraint yaparak, filtreleme ekliyoruz. 
    // new() eklememizin sebebi sadece new'lenebilen nesneleri yaz. Yani IEntity interface'ni yazama, implement eden classları yazabil...
    public interface IEntityRepository<T> where T : class, IEntity, new()   //(Sadece IEntity class nesneleri seçilebilsin!!!)
    {
        // Delegate yapısı... (Expression)
        List<T> GetAll(Expression<Func<T,bool>> filter =null);  // filter = null, filtre vermesemde çalışması için.
        T Get(Expression<Func<T, bool>> filter);  
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);


        // List<T> GetAllByCategory(int Id);
        // Delegate yapısı ile buna gerek kalmadı. Çünkü istediğimiz filtreyi verebiliyoruz.
    }
}
