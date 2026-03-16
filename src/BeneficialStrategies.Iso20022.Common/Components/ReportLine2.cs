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
[IsoId("_ToDCxNp-Ed-ak6NoX_4Aeg_1044270844")]
[DisplayName("Report Line")]
public record ReportLine2
{
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.
    /// </summary>
    [IsoId("_ToDCxdp-Ed-ak6NoX_4Aeg_1044270846")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification of the purchase order, assigned by the buyer.
    /// </summary>
    [IsoId("_ToDCxtp-Ed-ak6NoX_4Aeg_1044270862")]
    [DisplayName("Purchase Order Reference")]
    [IsoXmlTag("PurchsOrdrRef")]
    public required DocumentIdentification7 PurchaseOrderReference { get; init; }

    /// <summary>
    /// Specifies the adjustments applied to obtain the net amount.
    /// </summary>
    [IsoId("_ToDCx9p-Ed-ak6NoX_4Aeg_1398433973")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public Adjustment4? Adjustment { get; init; }

    /// <summary>
    /// Net amount, after adjustments, intended to be paid.
    /// </summary>
    [IsoId("_ToDCyNp-Ed-ak6NoX_4Aeg_1044270897")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public required CurrencyAndAmount NetAmount { get; init; }
}
