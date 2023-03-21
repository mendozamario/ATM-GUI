using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_GUI
{
    public class AtmLogic
    {
        int ten = 0;
        int twenty = 0;
        int fifty = 0;
        int oneHundred = 0;

        public AtmResponse MoneyCalculate(int entry)
        {
            AtmResponse atmResponse = new AtmResponse();
            if ((entry % 10000) == 0)
            {
                while (entry > 0)
                {
                    if(entry >= 10000)
                    {
                        entry -= 10000;
                        ten++;
                    }
                    if (entry >= 20000)
                    {
                        entry -= 20000;
                        twenty++;
                    }
                    if (entry >= 50000)
                    {
                        entry -= 50000;
                        fifty++;
                    }
                    if (entry >= 100000)
                    {
                        entry -= 100000;
                        oneHundred++;
                    }
                    if (entry >= 20000)
                    {
                        entry -= 20000;
                        twenty++;
                    }
                    if (entry >= 50000)
                    {
                        entry -= 50000;
                        fifty++;
                    }
                    if (entry >= 100000)
                    {
                        entry -= 100000;
                        oneHundred++;
                    }
                    if (entry >= 50000)
                    {
                        entry -= 50000;
                        fifty++;
                    }
                    if (entry >= 100000)
                    {
                        entry -= 100000;
                        oneHundred++;
                    }
                    if (entry >= 100000)
                    {
                        entry -= 100000;
                        oneHundred++;
                    }
                }
                atmResponse.Error = false;
                atmResponse.Money = GetMoney();
            } else
            {
                atmResponse.Error = true;
                atmResponse.Message = "El valor debe ser en multiplos de 10000, si no, no podremos entregar su dinero";
            }
            return atmResponse;
        }
        public List<int> GetMoney()
        {
            List<int> money = new List<int>
            {
                ten,
                twenty,
                fifty,
                oneHundred
            };
            return money;
        }
    }
}
