using CARD10.UniversalReadingList.Common;
using Lex.Db;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace CARD10.UniversalReadingList.App.Infrastructure
{
    public class Datasource
    {
        private DbInstance db;
        public Datasource()
        {
            db = new DbInstance("Storage", ApplicationData.Current.RoamingFolder);

            db.Map<Category>().Key(p => p.Id, true)
                .Map(p => p.Title)
                .WithIndex("Title", i => i.Title);


            db.Map<ReadItem>().Key(p => p.Id, true)
                .Map(p => p.CategoryId)
                .Map(p => p.Description)
                .Map(p => p.Title)
                .Map(p => p.Uri)
                .WithIndex("CategoryId", p => p.CategoryId)
                .WithIndex("Uri", p => p.Uri)
                .WithIndex("Title", p => p.Title);

            db.Initialize();
        }

        public DbTable<T> Table<T>()
            where T : class
        {
            return db.Table<T>();
        }

        public async Task DeleteAsync<T>(params T[] source)
            where T : class
        {
            await db.Table<T>().DeleteAsync(source);
        }

        public async Task DeleteByIdAsync<TKey, TTable>(params TKey[] keys)
            where TKey : struct
            where TTable : class
        {
            await db.Table<TTable>().DeleteByKeyAsync<TKey>(keys);
        }

        public async Task IncludeAsync<TTable>(params TTable[] source)
            where TTable : class
        {
            await Task.Factory.StartNew(() => db.Table<TTable>().Save(source));
        }

        public async Task TrunckTable<TTable>()
            where TTable : class
        {
            await db.Table<TTable>().PurgeAsync();
        }
    }
}
