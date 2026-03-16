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
[IsoId("_HOqx5ffjEei89sMSHxl1ew")]
[DisplayName("Amount")]
public record Amount13
{
    /// <summary>
    /// Describes the amount type.
    /// </summary>
    [IsoId("_HOqx5vfjEei89sMSHxl1ew")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; }

    /// <summary>
    /// Additional information about the amount.
    /// </summary>
    [IsoId("_HOqx6PfjEei89sMSHxl1ew")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Description { get; init; }

    /// <summary>
    /// Contains the amount.
    /// </summary>
    [IsoId("_HOqx5_fjEei89sMSHxl1ew")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }
}
