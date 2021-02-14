using QTS;
using QTS.IRepository;
using QTS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QTS
{
    public class ReciptRepo : Repository<ReceiptModel>, IRicipt
    {
        private readonly ReciptBodyDbContext _db;
        public ReciptRepo(ReciptBodyDbContext db):base(db)
        {
            _db = db;
        }

        public void Update(ReceiptModel receiptModel)
        {
            var data = _db.receiptModels.FirstOrDefault(s => s.ProductCode == receiptModel.ProductCode);

            data.ReciptNo = receiptModel.ReciptNo;
            data.UnitPrice = receiptModel.UnitPrice;
            data.UnitPrice = receiptModel.UnitPrice;
            data.Quantity = receiptModel.Quantity;
            data.Discount = receiptModel.Discount;
            data.Subtotal = receiptModel.Subtotal;
            data.NetTotaal = receiptModel.NetTotaal;

            _db.SaveChanges();


        }
    }
}
