using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13CS.Model
{
    public class HistoryHelper
    {
        private List<IHistory> _histories;

        public HistoryHelper()
        {
            _histories = new List<IHistory>();
        }

        public void AddItem(IHistory item)
        {
            _histories.Add(item);
        }

        public void SaveHistory()
        {
            try
            {
                _histories.ForEach(item => item.SaveHistory());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
