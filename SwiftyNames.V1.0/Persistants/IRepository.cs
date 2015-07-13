using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwiftyNames.V1._0.Persistants
{
    public interface IRepository
    {
        IList<NewsPapersPrice> GetNewsPaperTable();
    }
}