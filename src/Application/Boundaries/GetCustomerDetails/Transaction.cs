namespace Application.Boundaries.GetCustomerDetails
{
    using System;
    using Domain.Accounts.ValueObjects;

    /// <summary>
    /// Transaction.
    /// </summary>
    public sealed class Transaction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Transaction"/> class.
        /// </summary>
        /// <param name="description">Text description.</param>
        /// <param name="amount">Positive amount.</param>
        /// <param name="transactionDate">Transaction date.</param>
        public Transaction(
            string description,
            PositiveMoney amount,
            DateTime transactionDate)
        {
            Description = description;
            Amount = amount;
            TransactionDate = transactionDate;
        }

        /// <summary>
        /// Gets the description.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Gets the amount.
        /// </summary>
        public PositiveMoney Amount { get; }

        /// <summary>
        /// Gets the transaction date.
        /// </summary>
        public DateTime TransactionDate { get; }
    }
}
