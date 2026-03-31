// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies reasons for the pending status.
/// </summary>
[IsoId("_tRI8YUGSEeWqy4niLuXETA")]
[DisplayName("Pending Status Reason")]
public record PendingStatusReason9
{
    /// <summary>
    /// Specifies the reason why the instruction&apos;s processing is pending.
    /// </summary>
    [IsoId("_te0zA0GSEeWqy4niLuXETA")]
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public required PendingReason32Choice_ ReasonCode { get; init; }

    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    [IsoId("_te0zC0GSEeWqy4niLuXETA")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
