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
[IsoId("_CmM3wSdFEeaK04Z6iEcOJQ")]
[DisplayName("Interest Rate Contract Term")]
public record InterestRateContractTerm2
{
    /// <summary>
    /// Unit for the rate basis.
    /// </summary>
    [IsoId("_CwBiISdFEeaK04Z6iEcOJQ")]
    [DisplayName("Unit")]
    [IsoXmlTag("Unit")]
    public required RateBasis1Code Unit { get; init; }

    /// <summary>
    /// Value of the contract term in number of units.
    /// </summary>
    [IsoId("_CwBiIydFEeaK04Z6iEcOJQ")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max3Number)]
    public required IsoMax3Number Value { get; init; }
}
