using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TravelApp
{
    public class Core
    {
        public static int VOID = -255; //Отсутствие первичного ключа
        public static int NONE = -1; //Отсутсвие внешнего ключа

        //***********Обрашение к базе данных*************
        private static Data.mi_travelbaseEntities _Database;
        public static Data.mi_travelbaseEntities Database
        {
            get
            {
                if (_Database == null)
                {
                    _Database = new Data.mi_travelbaseEntities();
                }
                return _Database;
            }
        }
        //***********************************************

        public static MainWindow AppMainWindow;

        public static Data.Tour CurrentTour;

        //Процедура отмены изменений всех записей 
        public static void CancelAllChanges()
        {
            var ChangesEntries = Database.ChangeTracker.Entries().Where(E => E.State != EntityState.Unchanged).ToList();
            foreach (DbEntityEntry E in ChangesEntries)
            {
                CancelChanges(E);
            }
        }

        //Процедура отмены изменений одной записи 
        public static void CancelChanges(object Entity)
        {
            DbEntityEntry Entry = Database.Entry(Entity);
            try
            {
                switch (Entry.State)
                {
                    case EntityState.Added:
                        Entry.State = EntityState.Detached;
                        break;
                    case EntityState.Modified:
                        Entry.CurrentValues.SetValues(Entry.OriginalValues);
                        Entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Deleted:
                        Entry.State = EntityState.Unchanged;
                        break;
                }
            }
            catch
            {
                Entry.Reload();
            }
        }

        public static Style GetStyle(string styleName)
        {
            object Style;
            try
            {
                Style = Application.Current.FindResource(styleName);
            }
            catch
            {
                Style = null;
            }
            if (Style != null && Style is Style)
            {
                return Style as Style;
            }
            else
            {
                MessageBox.Show("Ошибка стилевого оформеления!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.None);
                return null;
            }
        }
    }
}
