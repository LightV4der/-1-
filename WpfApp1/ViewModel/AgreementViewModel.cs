using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    class AgreementViewModel
    {
        public ObservableCollection<Agreement> ListAgreement { get; set; } = new ObservableCollection<Agreement>();
        public AgreementViewModel()
        {
            this.ListAgreement.Add(
            new Agreement
            {
                Id = 1,
                Number = "1",
                DataOpen = new DateTime(2012, 05, 20),
                DataClose = new DateTime(2022, 05, 20)
                
            });
            this.ListAgreement.Add(
            new Agreement
            {
                Id = 2,
                Number = "2",
                DataOpen = new DateTime(2016, 07, 10),
                DataClose = new DateTime(2026, 07, 10)
            });
            this.ListAgreement.Add(
            new Agreement
            {
                Id = 3,
                Number = "3",
                DataOpen = new DateTime(2006, 06, 06),
                DataClose = new DateTime(2066, 06, 06)
            });
        }
        public int MaxId()
        {
            int max = 0;
            foreach (var a in this.ListAgreement)
            {
                if (max < a.Id)
                {
                    max = a.Id;
                };
            }
            return max;
        }
    }
}