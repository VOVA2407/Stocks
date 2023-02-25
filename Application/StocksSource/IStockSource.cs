using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.StocksSource;

internal interface IStockSource
{
    Stocks GetStocks();
}
