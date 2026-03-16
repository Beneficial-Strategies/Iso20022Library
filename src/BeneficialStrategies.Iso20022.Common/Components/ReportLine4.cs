// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a payment against a commercial invoice.
/// </summary>
[IsoId("_Tn5Ry9p-Ed-ak6NoX_4Aeg_-104260942")]
[DisplayName("Report Line")]
public record ReportLine4
{
    /// <summary>
    /// Reference to the identification of the underlying commercial document.
    /// </summary>
    [IsoId("_ToDCwNp-Ed-ak6NoX_4Aeg_-104260933")]
    [DisplayName("Commercial Document Reference")]
    [IsoXmlTag("ComrclDocRef")]
    public required InvoiceIdentification1 CommercialDocumentReference { get; init; }

    /// <summary>
    /// Specifies the adjustments applied to obtain the net amount.
    /// </summary>
    [IsoId("_ToDCwdp-Ed-ak6NoX_4Aeg_1409515872")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public ValueList<Adjustment4> Adjustment { get; init; } = [];

    /// <summary>
    /// Net amount, after adjustments, intended to be paid.
    /// </summary>
    [IsoId("_ToDCwtp-Ed-ak6NoX_4Aeg_-104260900")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public required CurrencyAndAmount NetAmount { get; init; }

    /// <summary>
    /// Specifies how the net amount to be paid is related to different purchase orders.
    /// </summary>
    [IsoId("_ToDCw9p-Ed-ak6NoX_4Aeg_202348166")]
    [DisplayName("Breakdown By Purchase Order")]
    [IsoXmlTag("BrkdwnByPurchsOrdr")]
    public ValueList<ReportLine2> BreakdownByPurchaseOrder { get; init; } = [];
    // ID for the above is _ToDCw9p-Ed-ak6NoX_4Aeg_202348166
}
