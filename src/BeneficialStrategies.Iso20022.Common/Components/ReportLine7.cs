// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a payment against a purchase order.
/// </summary>
[IsoId("_bnGykRrYEeOVR9VN6fAMUg")]
[DisplayName("Report Line")]
public record ReportLine7
{
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.
    /// </summary>
    [IsoId("_b-WN4RrYEeOVR9VN6fAMUg")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification of the purchase order, assigned by the buyer.
    /// </summary>
    [IsoId("_b-WN4xrYEeOVR9VN6fAMUg")]
    [DisplayName("Purchase Order Reference")]
    [IsoXmlTag("PurchsOrdrRef")]
    public required DocumentIdentification7 PurchaseOrderReference { get; init; }

    /// <summary>
    /// Specifies the adjustments applied to obtain the net amount.
    /// </summary>
    [IsoId("_b-WN5RrYEeOVR9VN6fAMUg")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public Adjustment6? Adjustment { get; init; }

    /// <summary>
    /// Net amount, after adjustments, intended to be paid.
    /// </summary>
    [IsoId("_b-WN5xrYEeOVR9VN6fAMUg")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public required CurrencyAndAmount NetAmount { get; init; }
}
