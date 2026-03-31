// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Billing Tax Region3.
/// </summary>
[IsoId("_YdfXJTE_Ee62xuUQ2zyZww")]
[DisplayName("Billing Tax Region3")]
public record BillingTaxRegion3
{
    /// <summary>
    /// Customer Tax Identification.
    /// </summary>
    [DisplayName("Customer Tax Identification")]
    [IsoXmlTag("CstmrTaxId")]
    public required IsoMax40Text CustomerTaxIdentification { get; init; }

    /// <summary>
    /// Invoice Number.
    /// </summary>
    [DisplayName("Invoice Number")]
    [IsoXmlTag("InvcNb")]
    public IsoMax40Text? InvoiceNumber { get; init; }

    /// <summary>
    /// Method C.
    /// </summary>
    [DisplayName("Method C")]
    [IsoXmlTag("MtdC")]
    public BillingMethod4? MethodC { get; init; }

    /// <summary>
    /// Point Date.
    /// </summary>
    [DisplayName("Point Date")]
    [IsoXmlTag("PtDt")]
    public IsoISODate? PointDate { get; init; }

    /// <summary>
    /// Region Name.
    /// </summary>
    [DisplayName("Region Name")]
    [IsoXmlTag("RgnNm")]
    public required IsoMax40Text RegionName { get; init; }

    /// <summary>
    /// Region Number.
    /// </summary>
    [DisplayName("Region Number")]
    [IsoXmlTag("RgnNb")]
    public required IsoMax40Text RegionNumber { get; init; }

    /// <summary>
    /// Sending Financial Institution.
    /// </summary>
    [DisplayName("Sending Financial Institution")]
    [IsoXmlTag("SndgFI")]
    public BillingTaxIdentification3? SendingFinancialInstitution { get; init; }

    /// <summary>
    /// Settlement Amount.
    /// </summary>
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public required AmountAndDirection34 SettlementAmount { get; init; }

    /// <summary>
    /// Tax Due To Region.
    /// </summary>
    [DisplayName("Tax Due To Region")]
    [IsoXmlTag("TaxDueToRgn")]
    public required AmountAndDirection34 TaxDueToRegion { get; init; }
}
