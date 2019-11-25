using MOD_PaymentService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_PaymentService.Repository
{
    public interface IPaymentRepository
    {
        void Add(Payment item);
        List<Payment> GetAll();
        Payment GetById(int id);
    }
}
