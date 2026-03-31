// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a pending account opening status.
/// </summary>
[IsoId("_nZh4IWCJEeabZtzjEVWYCQ")]
[DisplayName("Pending Opening Status Reason")]
public record PendingOpeningStatusReason1
{
    /// <summary>
    /// Reason for the pending account opening status.
    /// </summary>
    [IsoId("_nyhm8WCJEeabZtzjEVWYCQ")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required PendingOpeningStatusReason2Choice_ Code { get; init; }

    /// <summary>
    /// Additional information about the reason for the pending account opening status.
    /// </summary>
    [IsoId("_nyhm82CJEeabZtzjEVWYCQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
