using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_GUI
{
    public class AtmResponse
    {
        public bool Error { get; set; }
        public string Message { get; set; }
        public List<int> Money { get; set; }
        public AtmResponse() { }
        public AtmResponse(string message) {
            Message = message;
        }
        public AtmResponse(List<int> money) {
            Money = money;
        }
    }
}
