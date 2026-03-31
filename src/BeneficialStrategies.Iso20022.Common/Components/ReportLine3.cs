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
[IsoId("_Tn5Rx9p-Ed-ak6NoX_4Aeg_-1905127733")]
[DisplayName("Report Line")]
public record ReportLine3
{
    /// <summary>
    /// Unique identification of the purchase order, assigned by the buyer.
    /// </summary>
    [IsoId("_Tn5RyNp-Ed-ak6NoX_4Aeg_-1905127715")]
    [DisplayName("Purchase Order Reference")]
    [IsoXmlTag("PurchsOrdrRef")]
    public required DocumentIdentification7 PurchaseOrderReference { get; init; }

    /// <summary>
    /// Specifies the adjustments applied to obtain the net amount.
    /// </summary>
    [IsoId("_Tn5Rydp-Ed-ak6NoX_4Aeg_1400282122")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public ValueList<Adjustment4> Adjustment { get; init; } = [];

    /// <summary>
    /// Net amount, after adjustments, intended to be paid.
    /// </summary>
    [IsoId("_Tn5Rytp-Ed-ak6NoX_4Aeg_-1905127672")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public required CurrencyAndAmount NetAmount { get; init; }
}
