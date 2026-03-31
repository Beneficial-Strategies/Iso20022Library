// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a closure pending status.
/// </summary>
[IsoId("_0rCfkWCLEeabZtzjEVWYCQ")]
[DisplayName("Closure Pending Status Reason")]
public record ClosurePendingStatusReason1
{
    /// <summary>
    /// Reason for the closure pending status.
    /// </summary>
    [IsoId("_1EL_YWCLEeabZtzjEVWYCQ")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required ClosurePendingStatusReason2Choice_ Code { get; init; }

    /// <summary>
    /// Additional information about the reason for the closure pending status.
    /// </summary>
    [IsoId("_1EL_Y2CLEeabZtzjEVWYCQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
