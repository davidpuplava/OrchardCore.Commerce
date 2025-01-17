using Money;
using OrchardCore.Commerce.Abstractions;

namespace OrchardCore.Commerce.Models;

public class CreditCardPayment : IPayment
{
    public static readonly string CreditCardKind = "Credit Card";

    public string Kind => CreditCardKind;

    public string TransactionId { get; set; }

    public string ChargeText { get; set; }

    public Amount Amount { get; set; }

    /// <summary>
    /// Gets or sets the last 4 characters of the credit card number.
    /// </summary>
    public string Last4 { get; set; }

    /// <summary>
    /// Gets or sets the expiration month of the credit card.
    /// </summary>
    public int ExpirationMonth { get; set; }

    /// <summary>
    /// Gets or sets the expiration year of the credit card.
    /// </summary>
    public int ExpirationYear { get; set; }
}
