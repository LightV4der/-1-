using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    class BankViewModel
    {
        public int MaxId()
        {
            int max = 0;
            foreach (var b in this.ListBank)
            {
                if (max < b.Id)
                {
                    max = b.Id;
                };
            }
            return max;
        }
        public ObservableCollection<Bank> ListBank { get; set; } = new ObservableCollection<Bank>();
        public BankViewModel()
        {
            this.ListBank.Add(
            new Bank
            {
                Id = 1,
                NameFull = "Публичное акционерное общество «Сбербанк России»\r\n",
                NameShort = "Cбербанк",
                Inn = "7707083893",
                Bik = "044525225",
                KorAccount = "30101810400000000225",
                Account = "50234517800000002960",
                City = "Moscow"
            });
            this.ListBank.Add(
            new Bank
            {
                Id = 2,
                NameFull = "Акционерное общество \"Тинькофф Банк\"\r\n",
                NameShort = "АО \"Тинькофф Банк\"\r\n",
                Inn = "7710140679\r\n",
                Bik = "044525974",
                KorAccount = "30101810145250000974",
                Account = "50234517800000002960",
                City = "Moscow"
            });
            this.ListBank.Add(
            new Bank
            {
                Id = 3,
                NameFull = "Акционерное общество \"Альфа Банк\"\r\n",
                NameShort = "АО \"Альфа Банк\"\r\n",
                Inn = "7728168971",
                Bik = "044525593",
                KorAccount = "30101810200000000593",
                Account = "30101810200000000593",
                City = "Moscow"
            });
        }
    }
}