using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YongTest.CSharp
{
    public class EntityFrameTest {
        // using: handle IDisposible correctly
        public string GetContractNo(DateTime contractDate) {
            string result = "";
            using (var FastII = new FastIIEntities())
            {
                var query = from b in FastII.ArHeaders
                            where b.ContractDt == contractDate
                            select b;
                foreach (var contract in query)
                {
                    result += contract.ContractNo + "\r\n";
                }
            }
            return result;
        }

        // Task
        // Lambda 
        public Task<string>  GetContractNoAsync(DateTime contractDate)
        {
            Task<string> result = Task.Factory.StartNew<string>( 
                            () => { System.Threading.SpinWait.SpinUntil(()=> false, 20000);
                                    return GetContractNo(contractDate); } );
            return result;
        }

        // join
        // ?
        public string GetContractNoAndBalance(DateTime contractDate)
        {
            string result = "";
            using (var FastII = new FastIIEntities())
            {
                var query = from header in FastII.ArHeaders
                                join mastfl in FastII.ArMastfls on header.ContractNo equals mastfl.ContractNo 
                            where header.ContractDt == contractDate
                            select new { header.ContractNo, mastfl.CurBal } ;
                foreach (var contract in query)
                {
                    result += contract.ContractNo + ":" + contract.CurBal?.ToString("c") + "\r\n";
                }
            }
            return result;
        }

        // join
        // ?
        public string GetContractNoAndBalanceII(DateTime contractDate)
        {
            string result = "";
            using (var FastII = new FastIIEntities())
            {

                var query = from header in FastII.ArHeaders
                            join mastfl in FastII.ArMastfls on header.ContractNo equals mastfl.ContractNo
                            where header.ContractDt == contractDate
                            select new { header.ContractNo, mastfl.CurBal };
                foreach (var contract in query)
                {
                    result += contract.ContractNo + ":" + contract.CurBal?.ToString("c") + "\r\n";
                }
            }
            return result;
        }
    }
}
