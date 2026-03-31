// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Rejected Status Reason57.
/// </summary>
[IsoId("_NAT6oW5zEe6a272CIEgzKw")]
[DisplayName("Rejected Status Reason57")]
public record RejectedStatusReason57
{
    /// <summary>
    /// Additional Reason Information.
    /// </summary>
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }

    /// <summary>
    /// Reason Code.
    /// </summary>
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public required RejectedReason58Choice_ ReasonCode { get; init; }
}
