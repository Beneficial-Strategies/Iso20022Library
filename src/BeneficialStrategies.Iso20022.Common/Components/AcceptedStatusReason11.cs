// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies reasons for the accepted status.
/// </summary>
[IsoId("_6HWbl5NLEeWGlc8L7oPDIg")]
[DisplayName("Accepted Status Reason")]
public record AcceptedStatusReason11
{
    /// <summary>
    /// Specifies the reason why the instruction has been accepted.
    /// </summary>
    [IsoId("_6HWbm5NLEeWGlc8L7oPDIg")]
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public required AcceptedReason12Choice_ ReasonCode { get; init; }

    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    [IsoId("_6HWbn5NLEeWGlc8L7oPDIg")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; }
}
