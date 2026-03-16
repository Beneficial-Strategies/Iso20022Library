// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics of a tax efficient product.
/// </summary>
[IsoId("_jwT6wU7cEeifNrXGwadPmg")]
[DisplayName("Tax Efficient Product")]
public record TaxEfficientProduct3
{
    /// <summary>
    /// Type of tax efficient product, for example, an individual savings account (ISA) in the UK.
    /// </summary>
    [IsoId("_si-DMU7cEeifNrXGwadPmg")]
    [DisplayName("Tax Efficient Product Type")]
    [IsoXmlTag("TaxEffcntPdctTp")]
    public required TaxEfficientProductType1Choice_ TaxEfficientProductType { get; init; }

    /// <summary>
    /// Indicates whether the product contains a cash asset for transfer.
    /// </summary>
    [IsoId("_kAXwB07cEeifNrXGwadPmg")]
    [DisplayName("Cash Component Indicator")]
    [IsoXmlTag("CshCmpntInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CashComponentIndicator { get; init; }

    /// <summary>
    /// Investment plans issued during previous years.
    /// </summary>
    [IsoId("_kAXwCU7cEeifNrXGwadPmg")]
    [DisplayName("Previous Years")]
    [IsoXmlTag("PrvsYrs")]
    public PreviousYear4? PreviousYears { get; init; }

    /// <summary>
    /// Amounts already subscribed for the current year.
    /// </summary>
    [IsoId("_kAXwC07cEeifNrXGwadPmg")]
    [DisplayName("Current Year Subscription Details")]
    [IsoXmlTag("CurYrSbcptDtls")]
    public SubscriptionInformation2? CurrentYearSubscriptionDetails { get; init; }

    /// <summary>
    /// Additional information about the tax efficient product.
    /// </summary>
    [IsoId("_c860D07fEeifNrXGwadPmg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; }
}
