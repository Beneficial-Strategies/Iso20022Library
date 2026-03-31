// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for an accepted status.
/// </summary>
[IsoId("_-wWtPljyEeOnqqBHs8Gasw")]
[DisplayName("Accepted Status Reason")]
public record AcceptedStatusReason7
{
    /// <summary>
    /// Reason for the accepted status.
    /// </summary>
    [IsoId("_-wWtP1jyEeOnqqBHs8Gasw")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required AcceptedReason8Choice_ Reason { get; init; }

    /// <summary>
    /// Additional information about the processed instruction.
    /// </summary>
    [IsoId("_-wWtQ1jyEeOnqqBHs8Gasw")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
