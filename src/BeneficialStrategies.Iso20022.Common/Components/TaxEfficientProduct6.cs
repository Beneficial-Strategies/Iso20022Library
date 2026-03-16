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
[IsoId("__yVzAZNNEemQB_8XA98K0Q")]
[DisplayName("Tax Efficient Product")]
public record TaxEfficientProduct6
{
    /// <summary>
    /// Type of tax efficient product, for example, an individual savings account (ISA) in the UK.
    /// </summary>
    [IsoId("_AO5zM5NOEemQB_8XA98K0Q")]
    [DisplayName("Tax Efficient Product Type")]
    [IsoXmlTag("TaxEffcntPdctTp")]
    public required TaxEfficientProductType2Choice_ TaxEfficientProductType { get; init; }

    /// <summary>
    /// Indicates that all the current fiscal year’s products are to be included.
    /// </summary>
    [IsoId("_8OMPcZNQEemQB_8XA98K0Q")]
    [DisplayName("Current Year")]
    [IsoXmlTag("CurYr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CurrentYear { get; init; }

    /// <summary>
    /// Indicates whether the product contains a cash asset for transfer.
    /// </summary>
    [IsoId("_AO5zNZNOEemQB_8XA98K0Q")]
    [DisplayName("Cash Component Indicator")]
    [IsoXmlTag("CshCmpntInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CashComponentIndicator { get; init; }

    /// <summary>
    /// Investment plans issued during previous years.
    /// </summary>
    [IsoId("_AO5zN5NOEemQB_8XA98K0Q")]
    [DisplayName("Previous Years")]
    [IsoXmlTag("PrvsYrs")]
    public PreviousYear4? PreviousYears { get; init; }

    /// <summary>
    /// Amounts already subscribed for the current year.
    /// </summary>
    [IsoId("_AO5zOZNOEemQB_8XA98K0Q")]
    [DisplayName("Current Year Subscription Details")]
    [IsoXmlTag("CurYrSbcptDtls")]
    public SubscriptionInformation2? CurrentYearSubscriptionDetails { get; init; }

    /// <summary>
    /// Additional information about the tax efficient product.
    /// </summary>
    [IsoId("_AO5zO5NOEemQB_8XA98K0Q")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
