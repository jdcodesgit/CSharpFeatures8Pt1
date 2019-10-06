using CSharp8FeaturesPt1;
using NUnit.Framework;

namespace CSHarp8FeaturesPt1.Tests.Unit
{
    internal class DefaultInterfaceMembers
    {
        private IBankAccount _newBankAccount;
        private IBankAccount _shortTermBankAccount;
        private IBankAccount _midTermBankAccount;
        private IBankAccount _longTermBankAccount;
        private IBankAccount _zeroBalanceBankAccount;
        private IBankAccount _negativeBalanceBankAccount;

        [SetUp]
        public void Setup()
        {
            _newBankAccount = new BankAccount(1, 0, 2000);
            _shortTermBankAccount = new BankAccount(1, 1, 2000);
            _midTermBankAccount = new BankAccount(1, 3, 2000);
            _longTermBankAccount = new BankAccount(1, 6, 2000);
            _zeroBalanceBankAccount = new BankAccount(1, 6);
            _negativeBalanceBankAccount = new BankAccount(1, 6, -10);
        }

        [Test]
        public void ShouldReturn0SavingsRateForNewCustomersWithPositiveBalance()
        {
            var result = _newBankAccount.SavingsRate();
            Assert.AreEqual(0, result);
        }

        [Test]
        public void ShouldReturn0SavingsRateForShortTermCustomersWithPositiveBalance()
        {
            var result = _shortTermBankAccount.SavingsRate();
            Assert.AreEqual(0, result);
        }

        [Test]
        public void ShouldReturn2pt5SavingsRateForMidTermCustomersWithPositiveBalance()
        {
            var result = _midTermBankAccount.SavingsRate();
            Assert.AreEqual(2.5M, result);
        }

        [Test]
        public void ShouldReturn5SavingsRateForLongTermCustomersWithPositiveBalance()
        {
            var result = _longTermBankAccount.SavingsRate();
            Assert.AreEqual(5, result);
        }

        [Test]
        public void ShouldReturn0SavingsRateForLongTermCustomersWithZeroBalance()
        {
            var result = _zeroBalanceBankAccount.SavingsRate();
            Assert.AreEqual(0, result);
        }

        [Test]
        public void ShouldReturn0SavingsRateForLongTermCustomersWithNegativeBalance()
        {
            var result = _negativeBalanceBankAccount.SavingsRate();
            Assert.AreEqual(0, result);
        }
    }
}