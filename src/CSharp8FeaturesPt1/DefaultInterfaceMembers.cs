using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("CSHarp8FeaturesPt1.Tests.Unit")]
namespace CSharp8FeaturesPt1
{
    internal interface IBankAccount
    {
        // Original Customer Interface
        int Id { get; }
        DateTime CreatedDate { get; }
        decimal Balance { get; set; }
        int AccountAge { get { return (int)Math.Ceiling(DateTime.UtcNow.Subtract(CreatedDate).TotalDays / 365.25); } }

        // Interface Member extension
        public decimal SavingsRate() => DefaultSavingsRate(this);
        protected static decimal DefaultSavingsRate(IBankAccount b)
        {
            switch(b.AccountAge)
            {
                case var _ when b.AccountAge < 2: return 0;
                case var _ when b.AccountAge > 2 && b.AccountAge < 5: return 2.5M;
                case var _ when b.AccountAge >= 5: return 5;
                default: return 0;
            }
        }
    }

    internal class BankAccount : IBankAccount
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; }
        public decimal Balance { get; set; }

        public BankAccount(int id, int yearCount, decimal balance = 0)
        {
            Id = id;
            CreatedDate = DateTime.UtcNow.AddYears(yearCount * -1);
            Balance = balance;
        }

        public decimal SavingsRate() => Balance <= 1000 ? 0 : IBankAccount.DefaultSavingsRate(this);
    }

    internal class DefaultInterfaceMembers
    {
        public DefaultInterfaceMembers()
        {

        }
    }
}
