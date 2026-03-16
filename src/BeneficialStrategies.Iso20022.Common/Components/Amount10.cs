// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains the details of the billing amount
/// </summary>
[IsoId("_qju6dffBEei89sMSHxl1ew")]
[DisplayName("Amount")]
public record Amount10
{
    /// <summary>
    /// Description of the amount details.
    /// </summary>
    [IsoId("_qju6dvfBEei89sMSHxl1ew")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Description { get; init; }

    /// <summary>
    /// Contains the amount.
    /// </summary>
    [IsoId("_qju6ePfBEei89sMSHxl1ew")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Indicates whether or not the amount is a credit or debit.
    /// </summary>
    [IsoId("_qju6effBEei89sMSHxl1ew")]
    [DisplayName("Credit Indicator")]
    [IsoXmlTag("CdtInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CreditIndicator { get; init; }

    /// <summary>
    /// Tax applicable to the billing amount.
    /// </summary>
    [IsoId("_5NuCoPfBEei89sMSHxl1ew")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public ValueList<Tax33> Tax { get; init; } = [];
}
