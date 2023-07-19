using DesignPatternChainOfResponsibility.DAL;
using DesignPatternChainOfResponsibility.Models;

namespace DesignPatternChainOfResponsibility.ChainOfResponsibility
{
    public class RegionManager : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 350000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.CustomerSurname = req.CustomerSurname;
                customerProcess.EmployeeName = "Bölge Müdürü Yeliz Güneşli";
                customerProcess.Description = "Müşterinin talep ettiği tutar bölge müdürü tarafından ödenmiştir.";
                context.Add(customerProcess);
                context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.CustomerSurname = req.CustomerSurname;
                customerProcess.Amount = req.Amount;
                customerProcess.EmployeeName = "Bölge Müdürü Yeliz Güneşli";
                customerProcess.Description = "Müşterinin talep ettiği tutar bankanın günlük limitlerinin üzerinde olduğu için ödeme yapılamadı.";
                context.Add(customerProcess);
                context.SaveChanges();
            }
        }
    }
}
