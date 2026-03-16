// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Request Handling4.
/// </summary>
[IsoId("_4tFCR1QBEe-Fk_N0FBjY0Q")]
[DisplayName("Request Handling4")]
public record RequestHandling4
{
    /// <summary>
    /// Description.
    /// </summary>
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public IsoMax140Text? Description { get; init; }

    /// <summary>
    /// Status.
    /// </summary>
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required RequestStatus1Choice_ Status { get; init; }

    /// <summary>
    /// Status Reason.
    /// </summary>
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public StatusReasonInformation14? StatusReason { get; init; }
}
