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
[IsoId("_sCwFwexREeakeva4q26Yqg")]
[DisplayName("Interest Rate Contract Term")]
public record InterestRateContractTerm3
{
    /// <summary>
    /// Unit for the rate basis.
    /// </summary>
    [IsoId("_sO0L0exREeakeva4q26Yqg")]
    [DisplayName("Unit")]
    [IsoXmlTag("Unit")]
    public RateBasis1Code? Unit { get; init; }

    /// <summary>
    /// Value of the contract term in number of units.
    /// </summary>
    [IsoId("_sO0L0-xREeakeva4q26Yqg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max3Number)]
    public IsoMax3Number? Value { get; init; }
}
