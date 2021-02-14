using QTS.IRepository;
using QTS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace QTS.IRepository
{
    public interface IRicipt : IRepository<ReceiptModel>
    {
        void Update(ReceiptModel receiptModel);

    }
}