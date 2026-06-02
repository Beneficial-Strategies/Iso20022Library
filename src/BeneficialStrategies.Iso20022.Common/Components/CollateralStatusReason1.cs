// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Business status of the collateral data management request for processing in the system.
/// </summary>
[IsoId("_jBTw8e5NEeCisYr99QEiWA_246169338")]
[DisplayName("Collateral Status Reason1")]
public record CollateralStatusReason1
{
    /// <summary>
    /// Status of the collateral data maintenance instruction.
    /// </summary>
    [IsoId("_jBTw8u5NEeCisYr99QEiWA_132330272")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required Status6Code Status { get; init; }

    /// <summary>
    /// Reason for the status of a collateral data maintenance instruction.
    /// </summary>
    [IsoId("_jBTw8-5NEeCisYr99QEiWA_-750903015")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ValueList<StatusReasonInformation10> Reason { get; init; } = [];
}
