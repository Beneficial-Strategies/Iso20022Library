// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the reason why a cancellation request sent for the related instruction is pending.
/// </summary>
[IsoId("_NJb8wOBhEeiVRbNQx5-Vhg")]
[DisplayName("Pending Reason")]
public record PendingReason27
{
    /// <summary>
    /// Specifies the reason of the pending status expressed as a code.
    /// </summary>
    [IsoId("_LTyNQOBiEeiVRbNQx5-Vhg")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required PendingReason52Choice_ Code { get; init; }

    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    [IsoId("_ahx24OBhEeiVRbNQx5-Vhg")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
