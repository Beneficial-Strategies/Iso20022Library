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
[IsoId("_PDKHIZNNEemQB_8XA98K0Q")]
[DisplayName("Tax Efficient Product")]
public record TaxEfficientProduct4
{
    /// <summary>
    /// Type of tax efficient product, for example, an individual savings account (ISA) in the UK.
    /// </summary>
    [IsoId("_PogP4ZNNEemQB_8XA98K0Q")]
    [DisplayName("Tax Efficient Product Type")]
    [IsoXmlTag("TaxEffcntPdctTp")]
    public required TaxEfficientProductType2Choice_ TaxEfficientProductType { get; init; }

    /// <summary>
    /// Indicates that all the current fiscal year’s products are to be included.
    /// </summary>
    [IsoId("_PogP5ZNNEemQB_8XA98K0Q")]
    [DisplayName("Current Year")]
    [IsoXmlTag("CurYr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CurrentYear { get; init; }

    /// <summary>
    /// Investment plans issued during previous years.
    /// </summary>
    [IsoId("_PogP45NNEemQB_8XA98K0Q")]
    [DisplayName("Previous Years")]
    [IsoXmlTag("PrvsYrs")]
    public PreviousYear2Choice_? PreviousYears { get; init; }

    /// <summary>
    /// Additional information about the tax efficient product.
    /// </summary>
    [IsoId("_PogP55NNEemQB_8XA98K0Q")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
