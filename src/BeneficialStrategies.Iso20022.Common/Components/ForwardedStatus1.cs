// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status and quantity information related to a forwarded instruction request.
/// </summary>
[IsoId("_p-eGg473EfCbNJ3GwkFTcw")]
[DisplayName("Forwarded Status1")]
public record ForwardedStatus1
{
    /// <summary>
    /// Quantity of instructed securities previously accepted has now been forwarded along the chain.
    /// </summary>
    [IsoId("_p-eGhI73EfCbNJ3GwkFTcw")]
    [DisplayName("Forwarded Quantity")]
    [IsoXmlTag("FwddQty")]
    public Quantity51Choice_? ForwardedQuantity { get; init; }

    /// <summary>
    /// Reason for the forwarded status.
    /// </summary>
    [IsoId("_p-eGhY73EfCbNJ3GwkFTcw")]
    [DisplayName("Forwarded Reason")]
    [IsoXmlTag("FwddRsn")]
    public required NoSpecifiedReason1 ForwardedReason { get; init; }
}
