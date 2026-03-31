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
[IsoId("_KtgQBTt6EeW638lNyHKv7A")]
[DisplayName("Accepted Status Reason")]
public record AcceptedStatusReason8
{
    /// <summary>
    /// Specifies the reason why the instruction has been accepted.
    /// </summary>
    [IsoId("_LN8Dkzt6EeW638lNyHKv7A")]
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public required AcceptedReason9Choice_ ReasonCode { get; init; }

    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    [IsoId("_LN8Dlzt6EeW638lNyHKv7A")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
