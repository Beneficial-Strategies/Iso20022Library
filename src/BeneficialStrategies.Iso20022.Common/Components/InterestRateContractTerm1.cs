// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes how interest rates are reported.
/// </summary>
[IsoId("_CU8y8M5IEeSc85GUbgBycw")]
[DisplayName("Interest Rate Contract Term")]
public record InterestRateContractTerm1
{
    /// <summary>
    /// Unit for the rate basis.
    /// </summary>
    [IsoId("_IRIdgM5IEeSc85GUbgBycw")]
    [DisplayName("Unit")]
    [IsoXmlTag("Unit")]
    public required RateBasis1Code Unit { get; init; }

    /// <summary>
    /// Value of the contract term in number of units.
    /// </summary>
    [IsoId("_KLq3kM5IEeSc85GUbgBycw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber Value { get; init; }
}
