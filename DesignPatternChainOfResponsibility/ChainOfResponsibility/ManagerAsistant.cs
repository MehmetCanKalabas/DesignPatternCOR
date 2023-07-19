using DesignPatternChainOfResponsibility.DAL;
using DesignPatternChainOfResponsibility.Models;

namespace DesignPatternChainOfResponsibility.ChainOfResponsibility
{
    public class ManagerAsistant : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 150000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.CustomerSurname = req.CustomerSurname;
                customerProcess.EmployeeName = "Şube Müdür Yardımcısı Zeynep Çiçek";
                customerProcess.Description = "Müşterinin talep ettiği tutar müşteriye şube müdürü tarafından ödendi.";
                context.Add(customerProcess);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.CustomerSurname = req.CustomerSurname;
                customerProcess.EmployeeName = "Şube Müdür Yardımıcısı Zeynep Çiçek";
                customerProcess.Description = "Müşterinin talep ettiği tutar müşteriye şube müdür yardımcısı tarafından ödenemedi, işlem şube müdürüne aktarıldı";
                context.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);

            }
        }
    }
}
